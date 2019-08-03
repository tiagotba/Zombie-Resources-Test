import React, { Component } from "../../../node_modules/react";
import { Link } from "../../../node_modules/react-router-dom";

// import Logo from "../../assets/airbnb-logo.svg";

// import { Form, Container } from "./styless";

import "./index.scss";

import 'jquery';
import 'bootstrap/dist/js/bootstrap';


class SignUp extends Component {
  state = {
    username: "",
    email: "",
    password: "",
    error: ""
  };

  handleSignUp = e => {
    e.preventDefault();
    alert("Eu vou te registrar");
  };
  

  render() {
    
    return (
 
        // <form onSubmit={this.handleSignUp} className="form"></form>
          /* <img src="" alt="Airbnb logo" className="img" />
          {this.state.error && <p>{this.state.error}</p>}
          <input
            type="text"
            placeholder="Nome"
            className = "input"
            onChange={e => this.setState({ name: e.target.value })}
          />
          <input
            type="text"
            placeholder="Nome de usuário"
            className = "input"
            onChange={e => this.setState({ username: e.target.value })}
          />
          <input
            type="email"
            placeholder="Endereço de e-mail"
            className = "input"
            onChange={e => this.setState({ email: e.target.value })}
          />
          <input
            type="password"
            placeholder="Senha"
            className = "input"
            onChange={e => this.setState({ password: e.target.value })}
          />
          <button type="submit" className ="button">Cadastrar grátis</button>
          <hr />
          <Link to="/" className="a">Fazer login</Link> */
          
          <div class="container-fluid">
		<div class="container">
			<h2 class="text-center" id="title">Facundo farm and Resort</h2>
			 
 			<hr></hr>
			<div class="row">
      <form onSubmit={this.handleSignUp} className="form">
      {
				<div class="col-md-5">
 				
						<fieldset>							
							<p class="text-uppercase pull-center"> SIGN UP.</p>	
              <div class="form-group">
								<input type="text" name="name" id="name" class="form-control input-lg"   onChange={e => this.setState({name: e.target.value })} placeholder="nome"></input>
							</div>
 							<div class="form-group">
								<input type="text" name="username" id="username" class="form-control input-lg"   onChange={e => this.setState({ username: e.target.value })} placeholder="username"></input>
							</div>

							<div class="form-group">
								<input type="email" name="email" id="email" class="form-control input-lg" onChange={e => this.setState({ email: e.target.value })} placeholder="Email"></input>
							</div>
							<div class="form-group">
								<input type="number" name="idade" id="idade" class="form-control input-lg" onChange={e => this.setState({ idade: e.target.value })} placeholder="Idade"></input>
							</div>
								<div class="form-group">
								<input type="password" name="password" id="password" class="form-control input-lg" onChange={e => this.setState({ password: e.target.value })} placeholder="Password"></input>
							</div>
							
 							<div>
 									  <button type="submit" class="btn btn-lg btn-primary"></button>
 							</div>
						</fieldset>
					
        </div>
      }
        </form>
				
				<div class="col-md-2">
				
				</div>
				
				<div class="col-md-5">
 				 		<form role="form">
						<fieldset>							
							<p class="text-uppercase"> Login using your account: </p>	
 								
							<div class="form-group">
								<input type="email" name="username" id="username" class="form-control input-lg" placeholder="username"></input>
							</div>
							<div class="form-group">
								<input type="password" name="password" id="password" class="form-control input-lg" placeholder="Password"></input>
							</div>
							<div>
								<input type="submit" class="btn btn-md" value="Sign In"></input>
							</div>
								 
 						</fieldset>
				</form>	
				</div>
			</div>
		</div>
		<p class="text-center">
			<small id="passwordHelpInline" class="text-muted"> Developer:<a href="http://www.psau.edu.ph/"> Pampanga state agricultural university ?</a> BS. Information and technology students @2017 Credits: <a href="https://v4-alpha.getbootstrap.com/">boostrap v4.</a></small>
		</p>
	</div>
       
     
    );
  }
}

export default (SignUp);