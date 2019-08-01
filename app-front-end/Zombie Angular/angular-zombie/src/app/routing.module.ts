import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

 import { RecursosComponent } from './view components/recursos/recursos.component';
import { UsuariosComponent } from './view components/usuarios/usuarios.component';
import { MovimentosComponent } from './view components/movimentos/movimentos.component';
import { LoginComponent } from './login/login.component';
//  import { AuthService } from './login/auth.service;



const routes: Routes = [
  { path: '', redirectTo: '/login' , pathMatch: 'full' },
  { path: 'recursos',  component: RecursosComponent },
  { path: 'movimentos/:id', component: MovimentosComponent },
  { path: 'usuarios', component: UsuariosComponent },
  { path: 'login', component: LoginComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
// canActivate: [AuthGuard] ,
export class RoutingModule {}
