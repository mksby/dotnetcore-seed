import { Component, OnInit } from '@angular/core';
import { LoginService } from './login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  private user;

  loginUser(): void {
    this.user = this._loginUser.login().subscribe((data: any) => {
      console.log(data)
    });
  }

  constructor(private _loginUser: LoginService) {
  }

  ngOnInit() {

  }
}
