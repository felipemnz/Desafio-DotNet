import { Component, ElementRef, Injectable, Input, OnInit, ViewChild } from '@angular/core';
import { AplicationService } from 'src/app/service/aplicationService.service';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
})
@Injectable()
export class ClienteComponent implements OnInit{
    
    @Input() hidden: boolean = true;

    parametros: any = {};

    constructor(private aplicationService: AplicationService){

    }

    ngOnInit(): void {
        
    }

    cadastrar(){
      if(this.parametros.company_name == undefined || this.parametros.company_name == null){
        alert('Informe o nome da Compania')
        return false;
      }

      this.aplicationService.post('Cliente', this.parametros).subscribe(res => {
        if(res == true){
          alert("Cliente cadastrado")
          this.parametros = {};
        }else{
          alert("Erro ao cadastrar")
        }
      });

      return true;
    }

}