import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  public login() {
    return this.http.get('https://jsonplaceholder.typicode.com/todos/1');
  }

  constructor(private http: HttpClient) { }
}
