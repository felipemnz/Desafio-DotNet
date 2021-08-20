import { Component, ElementRef, Injectable, Input, OnInit, ViewChild } from '@angular/core';
import { AplicationService } from 'src/app/service/aplicationService.service';

@Component({
  selector: 'app-colaborador',
  templateUrl: './colaborador.component.html',
})
@Injectable()
export class ColaboradorComponent implements OnInit{
    
    @Input() hidden: boolean = true;

    parametros: any = {};
    colaboradores = new Array<any>();

    constructor(private aplicationService: AplicationService ){

    }

    ngOnInit(): void {
        
    }

    listarColaboradores(){
      this.aplicationService.get('Colaboradores', {
        dataInicial: this.parametros.dataInicial,
        dataFinal: this.parametros.dataFinal
      }).subscribe((res: any) => {
        if(res != undefined && res != null && res.length > 0){
          this.colaboradores = res;
        }else{
          alert("Nenhum registro encontrado!");
        } 
      });
    }

    cadastrar(){
      if((this.parametros.first_name == undefined || this.parametros.first_name == null) &&
         (this.parametros.last_name == undefined || this.parametros.last_name == null)){
        alert('Informe o primeiro e o ultimo nome.')
        return false;
      }

      this.aplicationService.post('Colaboradores', this.parametros).subscribe(res => {
        console.log(res)
        if(res == true){
          alert("Colaborador Cadastrado")
          this.parametros = {};
        }else{
          alert("Erro ao cadastrar")
        }
      });

      return true;
    }
}