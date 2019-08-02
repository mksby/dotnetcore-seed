import { Component, OnInit } from '@angular/core';
import { LoginService } from './login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  private _loginUser;
  private user;

  loginUser(): void{
    this.user = this._loginUser.login();
  }

  constructor(private loginService: LoginService) {
    this._loginUser = loginService;
  }

  ngOnInit() {

  }
}
