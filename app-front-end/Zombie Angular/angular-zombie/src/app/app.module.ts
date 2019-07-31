import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RoutingModule } from './routing.module';
import { DatePipe } from '@angular/common';


import { AppComponent } from './app.component';
import { MenuNavBarComponent } from './menu/menu-nav-bar/menu-nav-bar.component';

import { RecursoService } from './services/recurso.service';
import { MovimentosService } from './services/movimentos.service';
import { UsuarioService } from './services/usuario.service';

import { RecursosComponent } from './recursos/recursos.component';
import { UsuariosComponent } from './view components/usuarios/usuarios.component';
import { MovimentosComponent } from './view components/movimentos/movimentos.component';
import { LoginComponent } from './login/login.component';
import { AuthGuardService } from './guards/auth-guard.service';

@NgModule({
  declarations: [
    AppComponent,
    MenuNavBarComponent,
    RecursosComponent,
    UsuariosComponent,
    MovimentosComponent,
    LoginComponent,
    // DatePipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RoutingModule
  ],
  providers: [
    RecursoService,
    MovimentosService,
    UsuarioService,
    AuthGuardService,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
