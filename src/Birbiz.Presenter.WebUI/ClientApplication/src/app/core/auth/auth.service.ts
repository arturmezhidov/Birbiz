import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';

import { HttpConfig } from '../../config/http.config';
import { HttpService, ErrorResponse } from '../http'
import { Login, Register, Token } from './auth.models';
import { RegisterResponse, LoginResponse } from './responses';
import { LoginErrors } from './login-errors';
import { RegisterErrors } from './register-errors';

@Injectable()
export class AuthService  {

    private http: HttpService;

    constructor(http: HttpService) {
        this.http = http;
    }

    public login(model: Login): Observable<Token> {
        let body: string = this.createLoginBody(model);
        return this.http.post(HttpConfig.TOKEN_ENDPOINT, body, { isForm: true }).map((response: LoginResponse) => {
            return new Token(
                response.access_token,
                response.refresh_token,
                response.token_type,
                response.expires_in
            );
        }).catch((response: ErrorResponse) => {
            let error: LoginErrors = LoginErrors.parse(response);
            return Observable.throw(error);
        });
    }

    public register(model: Register): Observable<RegisterResponse> {
        return this.http.post(HttpConfig.REGISTER_URL, model).catch((response: ErrorResponse) => {
            let error: RegisterErrors = RegisterErrors.parse(response);
            return Observable.throw(error);
        });
    }

    private createLoginBody(model: Login): string {
        let body = `username=${(model.login || "")}&password=${(model.password || "")}&grant_type=password`;
        return body;
    }
}