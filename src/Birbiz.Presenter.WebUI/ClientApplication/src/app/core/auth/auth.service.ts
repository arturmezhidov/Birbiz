import { Injectable } from '@angular/core';

import { HttpConfig } from '../../config/http.config'
import { HttpService } from '../http'

import { Login, Register } from './models'

@Injectable()
export class AuthService  {

    private http: HttpService;

    constructor(http: HttpService) {
        this.http = http;
    }

    public login(model: Login): void {
        this.http.post(HttpConfig.LOGIN_URL, model)
            .subscribe((data) => {
                console.log(data);
            });
    }

    public register(model: Register): void {
        this.http.post(HttpConfig.REGISTER_URL, model)
            .subscribe((data) => {
                console.log(data);
            });
    }
}