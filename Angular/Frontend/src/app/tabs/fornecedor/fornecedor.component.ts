import { Component, ElementRef, Injectable, Input, OnInit, ViewChild } from '@angular/core';
import { AplicationService } from 'src/app/service/aplicationService.service';

@Component({
  selector: 'app-fornecedor',
  templateUrl: './fornecedor.component.html',
})
@Injectable()
export class FornecedorComponent implements OnInit{
    
    @Input() hidden: boolean = true;

    parametros: any = {};

    constructor(private aplicationService: AplicationService){

    }

    ngOnInit(): void {
        
    }

    cadastrar(){
      if(this.parametros.company_name == undefined || this.parametros.company_name == null){
        alert('Informe o nome da compania')
        return false;
      }

      this.aplicationService.post('Fornecedor', this.parametros).subscribe(res => {
        if(res == true){
          alert("Fornecedor cadastrado")
          this.parametros = {};
        }else{
          alert("Erro ao cadastrar")
        }
      });

      return true;
    }
}