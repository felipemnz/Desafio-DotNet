import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ServicesModule } from './service/services.module';
import { ProdutoComponent } from './tabs/produto/produto.component';
import { PedidoComponent } from './tabs/pedidos/pedidos.component';
import { FornecedorComponent } from './tabs/fornecedor/fornecedor.component';
import { ExpedidorComponent } from './tabs/expedidor/expedidor.component';
import { ColaboradorComponent } from './tabs/colaborador/colaborador.component';
import { ClienteComponent } from './tabs/cliente/cliente.component';
import { CategoriaComponent } from './tabs/categoria/categoria.component';

@NgModule({
  declarations: [
    AppComponent,
    ProdutoComponent,
    PedidoComponent,
    FornecedorComponent,
    ExpedidorComponent,
    ColaboradorComponent,
    ClienteComponent,
    CategoriaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ServicesModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
