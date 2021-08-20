import { Component, ElementRef, Injectable, Input, OnInit, ViewChild } from '@angular/core';
import { AplicationService } from 'src/app/service/aplicationService.service';

@Component({
  selector: 'app-pedido',
  templateUrl: './pedidos.component.html',
})
@Injectable()
export class PedidoComponent implements OnInit{
    
    @Input() hidden: boolean = true;

    parametros: any = {};

    pedidos = new Array<any>();
    clientes = new Array<any>();
    expedidores = new Array<any>();
    colaborador = new Array<any>();

    constructor(private aplicationService: AplicationService){
      this.parametros.customer_id = 0;
      this.parametros.shipper_id = 0;
      this.parametros.employee_id = 0;
      this.parametros.clienteId = 0;
      this.parametros.expedidorId = 0;
    }

    ngOnInit(): void {
        this.listarCliente();
        this.listarExpedidor();
        this.listarColaboradores()

    }

    listarCliente(){
      this.aplicationService.get('Cliente').subscribe((res: any) => {
        this.clientes = res;
      });
    }

    listarExpedidor(){
      this.aplicationService.get('Expedidor').subscribe((res: any) => {
        this.expedidores = res;
      });
    }

    listarColaboradores(){
      this.aplicationService.get('COlaboradores', {dataInicial: new Date(), dataFinal: new Date()}).subscribe((res: any) => {
        this.colaborador = res;
      });
    }

    listarPedidos(){
      this.aplicationService.get('Pedido', {
        id_cliente: this.parametros.clienteId,
        id_expedidor: this.parametros.expedidorId
      }).subscribe((res: any) => {
        
        if(res != undefined && res != null && res.length > 0){
          this.pedidos = res;
        }else{
          alert("Nenhum registro encontrado!");
        }
      });
    }

    cadastrar(){
      if((this.parametros.customer_id == 0 || this.parametros.shipper_id == 0 || this.parametros.employee_id == 0)){
        alert('Selecione um Cliente, um Expedidor e um Colaborador. Se não existir nenhuma opção, vá até a aba de Cliente ou Expedidor ou Colaborador para realizar o cadastro, se persistir, atualize a pagina')
        return false;
      }

      this.aplicationService.post('Pedido', this.parametros).subscribe(res => {
        if(res == true){
          alert("Pedido Cadastrado")
          this.parametros = {};
          this.parametros.customer_id = 0;
          this.parametros.shipper_id = 0;
          this.parametros.employee_id = 0;
          this.parametros.clienteId = 0;
          this.parametros.expedidorId = 0;
        }else{
          alert("Erro ao cadastrar")
        }
      });

      return true;
    }

    formatDate(date : Date){
       date = new Date(date);

       var day = date.getDay() < 10? "0"+date.getDay():date.getDay();
       var month = date.getMonth() < 10? "0"+date.getMonth(): date.getMonth();
       var year = date.getFullYear();

       return day+"-"+month+"-"+year;
    }

}