import { Component, ElementRef, Injectable, Input, OnInit, ViewChild } from '@angular/core';
import { AplicationService } from 'src/app/service/aplicationService.service';

@Component({
  selector: 'app-expedidor',
  templateUrl: './expedidor.component.html',
})
@Injectable()
export class ExpedidorComponent implements OnInit{
    
    @Input() hidden: boolean = true;

    parametros: any = {};

    constructor(private aplicationService: AplicationService){

    }

    ngOnInit(): void {
        
    }

    cadastrar(){
      if(this.parametros.company_name == undefined || this.parametros.company_name == null){
        alert('O nome da Compania de ser preenchido')
        return false;
      }

      this.aplicationService.post('Expedidor', this.parametros).subscribe(res => {
        if(res == true){
          this.parametros = {}
          alert("Expedidor cadastrado");
        }else{
          alert("Erro ao cadastrar")
        }
      });

      return true;
    }
}