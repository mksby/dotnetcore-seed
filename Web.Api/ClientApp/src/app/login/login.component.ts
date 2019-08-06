import { Component, OnInit } from '@angular/core';
import { LoginService } from './login.service';
import { Router } from '@angular/router'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  private user;

  loginUser(): void {
    this.user = this._loginUser.login().subscribe((data: any) => {
      this._router.navigate(['map'])
    });
  }

  constructor(private _loginUser: LoginService, private _router: Router) {
  }

  ngOnInit() {

  }
}
