import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Observer } from 'rxjs/Observer';

import { HttpConfig } from '../../config/http.config'
import { HttpService, ErrorResponse, TokenService, Token } from '../http'

import { Login } from './login';
import { LoginResponse } from './login-response';
import { LoginErrors } from './login-errors';
import { Register } from './register';
import { RegisterResponse } from './register-response';
import { RegisterErrors } from './register-errors';

@Injectable()
export class AuthService  {

    private http: HttpService;
    private tokenService: TokenService;

    constructor(http: HttpService, tokenService: TokenService) {
        this.http = http;
        this.tokenService = tokenService;
    }

    public login(model: Login): Observable<LoginResponse> {
        let body: string = this.createLoginBody(model);
        let observable: Observable<LoginResponse> = Observable.create((observer: Observer<any>) => {
            this.http.post(HttpConfig.TOKEN_ENDPOINT, body, { isForm: true }).subscribe((token: Token) => {
                this.tokenService.setToken(token);
                let response: LoginResponse = new LoginResponse();
                response.token = token;
                observer.next(response);
            }, (response: ErrorResponse) => {
                let error: LoginErrors = LoginErrors.parse(response);
                observer.error(error);
            });
        });
        return observable;
    }

    public register(model: Register): Observable<RegisterResponse> {
        let observable: Observable<RegisterResponse> = Observable.create((observer: Observer<any>) => {
            this.http.post(HttpConfig.REGISTER_URL, model).subscribe((response: RegisterResponse) => {
                observer.next(response);
            }, (response: ErrorResponse) => {
                let error: RegisterErrors = RegisterErrors.parse(response);
                observer.error(error);
            });
        });
        return observable;
    }

    public logout(): void {
        this.tokenService.removeToken();
    }

    public isLoggedIn(): boolean {
        return this.tokenService.hasToken();
    }

    private createLoginBody(model: Login): string {
        let body = `username=${(model.login || "")}&password=${(model.password || "")}&grant_type=password`;
        return body;
    }
}