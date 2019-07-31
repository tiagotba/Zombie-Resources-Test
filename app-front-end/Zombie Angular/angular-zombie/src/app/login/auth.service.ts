import { Router } from '@angular/router';
import { Injectable, EventEmitter } from '@angular/core';

import { Usuario } from '../entities/Usuario';


@Injectable()
export class AuthService {

  private usuarioAutenticado: boolean = false;

  constructor(private router: Router) { }

  fazerLogin(usuario: Usuario){

    if (usuario.Login === 'usuario@email.com' &&
      usuario.Senha === '123456') {

      this.usuarioAutenticado = true;


      this.router.navigate(['/']);

    } else {
      this.usuarioAutenticado = false;
    }
  }

  usuarioEstaAutenticado(){
    return this.usuarioAutenticado;
  }

}
