import { Component, ElementRef, Injectable, Input, OnInit, ViewChild } from '@angular/core';
import { AplicationService } from 'src/app/service/aplicationService.service';

@Component({
  selector: 'app-categoria',
  templateUrl: './categoria.component.html',
})
@Injectable()
export class CategoriaComponent implements OnInit{
    
    @Input() hidden: boolean = true;

    constructor(private aplicationService: AplicationService){

    }

    parametros: any = {};

    ngOnInit(): void {
        
    }

    cadastrar(){
      if(this.parametros.category_name == undefined || this.parametros.category_name == null){
        alert('Informe o nome da Categoria')
        return false;
      }

      this.aplicationService.post('Categoria', this.parametros).subscribe(res => {
        if(res == true){
          alert("Categoria cadastrada")
          this.parametros = {};
        }else{
          alert("Erro ao cadastrar")
        }
      });

      return true;
    }

}