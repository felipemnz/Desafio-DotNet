import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { AplicationService } from './service/aplicationService.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent implements OnInit{
  
  title = 'Frontend';

  @ViewChild('Produtos') Produtos?: ElementRef;
  @ViewChild('Fornecedor') Fornecedor?: ElementRef;
  @ViewChild('Categorias') Categorias?: ElementRef;
  @ViewChild('Pedidos') Pedidos?: ElementRef;
  @ViewChild('Clientes') Clientes?: ElementRef;
  @ViewChild('Expedidores') Expedidores?: ElementRef;
  @ViewChild('Colaboradores') Colaboradores?: ElementRef;
  
  HiddenProdutos: boolean = false;
  HiddenFornecedor: boolean = false;
  HiddenCategorias: boolean = false;
  HiddenPedidos: boolean = false;
  HiddenClientes: boolean = false;
  HiddenExpedidores: boolean = false;
  HiddenColaboradores: boolean = false;

  serviceUrl = "Categoria";

  constructor(private service: AplicationService){
    
  }

  ngOnInit(): void {
    
  }

  select(tabId: number): void{
    switch(tabId){
      case 1:
        this.Fornecedor?.nativeElement.classList.remove('active');
        this.Categorias?.nativeElement.classList.remove('active');
        this.Pedidos?.nativeElement.classList.remove('active');
        this.Clientes?.nativeElement.classList.remove('active');
        this.Expedidores?.nativeElement.classList.remove('active');
        this.Colaboradores?.nativeElement.classList.remove('active');

        this.HiddenProdutos = true;
        this.HiddenFornecedor = false;
        this.HiddenCategorias = false;
        this.HiddenPedidos = false;
        this.HiddenClientes = false;
        this.HiddenExpedidores = false;
        this.HiddenColaboradores = false;

        
        this.Produtos?.nativeElement.classList.add('active');
      break;

      case 2:
        this.Produtos?.nativeElement.classList.remove('active');
        this.Categorias?.nativeElement.classList.remove('active');
        this.Pedidos?.nativeElement.classList.remove('active');
        this.Clientes?.nativeElement.classList.remove('active');
        this.Expedidores?.nativeElement.classList.remove('active');
        this.Colaboradores?.nativeElement.classList.remove('active');

        this.HiddenProdutos = false;
        this.HiddenFornecedor = true;
        this.HiddenCategorias = false;
        this.HiddenPedidos = false;
        this.HiddenClientes = false;
        this.HiddenExpedidores = false;
        this.HiddenColaboradores = false;


        this.Fornecedor?.nativeElement.classList.add('active');
      break;

      case 3:
        this.Fornecedor?.nativeElement.classList.remove('active');
        this.Produtos?.nativeElement.classList.remove('active');
        this.Pedidos?.nativeElement.classList.remove('active');
        this.Clientes?.nativeElement.classList.remove('active');
        this.Expedidores?.nativeElement.classList.remove('active');
        this.Colaboradores?.nativeElement.classList.remove('active');

        this.HiddenProdutos = false;
        this.HiddenFornecedor = false;
        this.HiddenCategorias = true;
        this.HiddenPedidos = false;
        this.HiddenClientes = false;
        this.HiddenExpedidores = false;
        this.HiddenColaboradores = false;


        this.Categorias?.nativeElement.classList.add('active');
      break;

      case 4:
        this.Fornecedor?.nativeElement.classList.remove('active');
        this.Produtos?.nativeElement.classList.remove('active');
        this.Categorias?.nativeElement.classList.remove('active');
        this.Clientes?.nativeElement.classList.remove('active');
        this.Expedidores?.nativeElement.classList.remove('active');
        this.Colaboradores?.nativeElement.classList.remove('active');

        this.HiddenProdutos = false;
        this.HiddenFornecedor = false;
        this.HiddenCategorias = false;
        this.HiddenPedidos = true;
        this.HiddenClientes = false;
        this.HiddenExpedidores = false;
        this.HiddenColaboradores = false;

        this.Pedidos?.nativeElement.classList.add('active');
      break;
      case 5:
        this.Fornecedor?.nativeElement.classList.remove('active');
        this.Produtos?.nativeElement.classList.remove('active');
        this.Categorias?.nativeElement.classList.remove('active');
        this.Pedidos?.nativeElement.classList.remove('active');
        this.Expedidores?.nativeElement.classList.remove('active');
        this.Colaboradores?.nativeElement.classList.remove('active');

        this.HiddenProdutos = false;
        this.HiddenFornecedor = false;
        this.HiddenCategorias = false;
        this.HiddenPedidos = false;
        this.HiddenClientes = true;
        this.HiddenExpedidores = false;
        this.HiddenColaboradores = false;


        this.Clientes?.nativeElement.classList.add('active');
      break;
      case 6:
        this.Fornecedor?.nativeElement.classList.remove('active');
        this.Produtos?.nativeElement.classList.remove('active');
        this.Categorias?.nativeElement.classList.remove('active');
        this.Pedidos?.nativeElement.classList.remove('active');
        this.Clientes?.nativeElement.classList.remove('active');
        this.Colaboradores?.nativeElement.classList.remove('active');

        this.HiddenProdutos = false;
        this.HiddenFornecedor = false;
        this.HiddenCategorias = false;
        this.HiddenPedidos = false;
        this.HiddenClientes = false;
        this.HiddenExpedidores = true;
        this.HiddenColaboradores = false;


        this.Expedidores?.nativeElement.classList.add('active');
      break;
      case 7:
        this.Fornecedor?.nativeElement.classList.remove('active');
        this.Produtos?.nativeElement.classList.remove('active');
        this.Categorias?.nativeElement.classList.remove('active');
        this.Pedidos?.nativeElement.classList.remove('active');
        this.Clientes?.nativeElement.classList.remove('active');
        this.Expedidores?.nativeElement.classList.remove('active');

        this.HiddenProdutos = false;
        this.HiddenFornecedor = false;
        this.HiddenCategorias = false;
        this.HiddenPedidos = false;
        this.HiddenClientes = false;
        this.HiddenExpedidores = false;
        this.HiddenColaboradores = true;

        this.Colaboradores?.nativeElement.classList.add('active');
      break;
    }
  }
}
