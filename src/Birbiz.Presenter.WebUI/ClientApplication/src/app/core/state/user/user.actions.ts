import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { NgRedux } from 'ng2-redux';

import { IAppState } from '../';
import { UserService, UserInfo } from '../../user';
import { AuthService, Login, Token } from '../../auth';
import {
    LOGIN_USER,
    LOGIN_USER_SUCCESS,
    LOGOUT_USER,
    TOKEN_UPDATE,
    USER_LOADING,
    USER_LOADED,
    ACCOUNT_LOCK,
    ACCOUNT_UNLOCK,
    SCREEN_LOCK,
    SCREEN_UNLOCK
} from './user.constants';

@Injectable()
export class UserActions {

    private ngRedux: NgRedux<IAppState>;
    private authService: AuthService;
    private userService: UserService;

    constructor(ngRedux: NgRedux<IAppState>, userService: UserService, authService: AuthService) {
        this.ngRedux = ngRedux;
        this.userService = userService;
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

    public updateToken(token: Token) {
        return this.ngRedux.dispatch({
            type: TOKEN_UPDATE,
            payload: token
        });
    }

    public loadUserInfo(): Observable<UserInfo> {
        this.ngRedux.dispatch({ type: USER_LOADING });
        return this.userService.getUserInfo().map((userInfo: UserInfo) => {
            return this.ngRedux.dispatch({
                type: USER_LOADED,
                payload: userInfo
            });
        });
    }

    public logout(): any {
        return this.ngRedux.dispatch({ type: LOGOUT_USER });
    }

    public accountLock(): any {
        return this.ngRedux.dispatch({ type: ACCOUNT_LOCK });
    }

    public accountUnlock(): any {
        return this.ngRedux.dispatch({ type: ACCOUNT_UNLOCK });
    }

    public screenLock(): any {
        return this.ngRedux.dispatch({ type: SCREEN_LOCK });
    }

    public screenUnlock(): any {
        return this.ngRedux.dispatch({ type: SCREEN_UNLOCK });
    }
}