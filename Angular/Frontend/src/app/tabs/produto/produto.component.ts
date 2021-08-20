
import { Component, ElementRef, Injectable, Input, OnInit, ViewChild } from '@angular/core';
import { AplicationService } from 'src/app/service/aplicationService.service';

@Component({
  selector: 'app-produto',
  templateUrl: './produto.component.html',
})
@Injectable()
export class ProdutoComponent implements OnInit{
    
    @Input() hidden: boolean = true;

    categorias = new Array<any>();
    fornecedores = new Array<any>();
    produtos = new Array<any>();

    parametros: any = {};

    constructor(private aplicationService: AplicationService){
      this.parametros.categoria = 0;
      this.parametros.fornecedor = 0;
      this.parametros.supplier_id = 0;
      this.parametros.category_id = 0;
    }

    ngOnInit(): void {
        this.listarCategoria();
        this.listarExpedidor();
    }

    listarCategoria(){
      this.aplicationService.get('Categoria').subscribe((res: any) => {
        this.categorias = res;
      });
    }

    listarExpedidor(){
      this.aplicationService.get('Fornecedor').subscribe((res: any) => {
        this.fornecedores = res;
      });
    }

    listarProdutos(){
      this.aplicationService.get('Produto', {
        id_categoria: this.parametros.categoria,
        id_fornecedor: this.parametros.fornecedor
      }).subscribe((res: any) => {
        if(res != undefined && res != null && res.length > 0){
          this.produtos = res;
        }else{
          alert("Nenhum registro encontrado!");
        }
      });
    }

    cadastrar(){
      if(this.parametros.supplier_id == 0 || this.parametros.category_id == 0){
        alert('Informe o Fornecedor e a Categoria do produto. Caso nenhuma opção esteja disponivel, vá para a aba de Fornecedor ou de Categoria, ou atualize a pagina')
        return false;
      }

      this.aplicationService.post('Produto', this.parametros).subscribe(res => {
        if(res == true){
          alert("produto cadastrado")
          this.parametros = {};
          this.parametros.categoria = 0;
          this.parametros.fornecedor = 0;
          this.parametros.supplier_id = 0;
          this.parametros.category_id = 0;
        }else{
          alert("Erro ao cadastrar")
        }
      });

      return true;
    }

}