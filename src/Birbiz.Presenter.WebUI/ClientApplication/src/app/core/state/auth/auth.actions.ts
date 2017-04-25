import { Injectable } from '@angular/core';
import { NgRedux } from 'ng2-redux';

import { IAppState } from '../';
import { AuthService, Login, Token } from '../../auth';
import { TokenStorage } from './token-storage';
import { LOGIN_USER, LOGIN_USER_SUCCESS, LOGOUT_USER, TOKEN_UPDATE } from './auth.constants';

@Injectable()
export class AuthActions {

    private ngRedux: NgRedux<IAppState>;
    private authService: AuthService;

    constructor(ngRedux: NgRedux<IAppState>, authService: AuthService) {
        this.ngRedux = ngRedux;
        this.authService = authService;
    }

    public login(model: Login): any {
        this.ngRedux.dispatch({ type: LOGIN_USER });
        return this.authService.login(model).map((token: Token) => {
            return this.ngRedux.dispatch({
                type: LOGIN_USER_SUCCESS,
                payload: token
            });
        });
    }

    public logout(): any {
        return this.ngRedux.dispatch({ type: LOGOUT_USER });
    }

    public updateToken(token: Token) {
        return this.ngRedux.dispatch({
            type: TOKEN_UPDATE,
            payload: token
        });
    }
}