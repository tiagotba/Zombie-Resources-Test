import { Component, OnInit } from '@angular/core';
import { AuthService } from './auth.service';
import { Usuario } from '../entities/Usuario';
import { Sobreviventes } from '../entities/Sobreviventes';
import { UsuarioService } from '../services/usuario.service';
import { environment } from 'environments/environment';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  providers : [AuthService]
})
export class LoginComponent implements OnInit {
  private Usuario: Sobreviventes;
  constructor(private usuarioService: UsuarioService) { }

  ngOnInit() {
    // AuthServi
  }

  salvar(){
    let user = this.Usuario;
    // this.Usuario = new Sobrevivente("", "");
    console.log(user);
    this.usuarioService.addUsuario(user)
      .subscribe((value)=>  alert("Usuário(a) \""+user.Nome+"\" registrado(a) com sucesso"),
        error => this.erro(error));
  }

  erro(error){
    console.log(error);
    let msg = "";
    try{
      let msgs = JSON.parse(JSON.parse(error._body).Message);
      for(let m in msgs){
        if(msgs[m]){
          msg += msgs[m].Value + ";\n";
        }
      }
    }catch(e){
      msg = JSON.parse(error._body).Message
    }
    alert(msg)
  }



}
