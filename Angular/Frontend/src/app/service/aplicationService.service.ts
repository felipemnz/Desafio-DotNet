import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";


@Injectable()
export class AplicationService{

    constructor(
        private http: HttpClient
    ){

    }

    get(service: string, data?: any){
        let url = environment.serviceUrl + service;

        if (data) {
			if (data !== Object(data)) {
				url += '/' + data;
			} else {
				url += '?' + this.objectToQueryString(data);
            }

		}

        return this.http.get(url);
    }

    post(service: string, data?: any){
        const url = environment.serviceUrl + service;

		return this.http.post(url, data);
    }

    private objectToQueryString(obj: any) {
		const str = <any>[];

		this.iterate(obj, str);

		return str.join('&');
	}

    private iterate(obj: any, str: any, propertyParent?: any) {
		for (const property in obj) {
			if (obj.hasOwnProperty(property)) {
				if (typeof obj[property] == 'object') {
					this.iterate(obj[property], str, property);
				} else {
					let key = property;

					if (propertyParent) { key = propertyParent + '.' + property; }

					if (obj[property]) {
						str.push(encodeURIComponent(key) + '=' + encodeURIComponent(obj[property]));
					}
				}
			}
		}
	}
}