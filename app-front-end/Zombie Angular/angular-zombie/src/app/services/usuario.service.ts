import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions, Response } from '@angular/http'

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';

import { Usuario } from '../entities/Usuario';
import { Sobreviventes } from '../entities/Sobreviventes';
import { environment } from 'environments/environment';

@Injectable()
export class UsuarioService {

  private urlDefault = "http://localhost:53364/api/sobrevivente";

  constructor(private http: Http) { }

  public addUsuario(sobrevivente: Sobreviventes): Observable<any>{
      let bodyString = JSON.stringify(sobrevivente);
      let headers = new Headers({ 'Content-Type': 'application/json' });
      let options = new RequestOptions({ headers: headers, body: bodyString, method:"POST" });

      return this.http.post(this.urlDefault, bodyString, options)
                      // .map(res => res.json())
                      .catch(this.handleError);
  }

  private handleError(error: any): Promise<any> {
    console.error('Erro UsuarioService', error);
    return Promise.reject(error.message || error);
  }
}
