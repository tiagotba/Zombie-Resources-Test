import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { RecursosComponent } from './recursos/recursos.component';
import { UsuariosComponent } from './view components/usuarios/usuarios.component';
import { MovimentosComponent } from './view components/movimentos/movimentos.component';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './guards/auth.guard';

const routes: Routes = [
  { path: '', redirectTo: '/login' , pathMatch: 'full' },
  { path: 'recursos', canActivate: [AuthGuard] ,component: RecursosComponent },
  { path: 'movimentos/:id', component: MovimentosComponent },
  { path: 'usuarios', component: UsuariosComponent },
  { path: 'login', component: LoginComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})

export class RoutingModule {}
