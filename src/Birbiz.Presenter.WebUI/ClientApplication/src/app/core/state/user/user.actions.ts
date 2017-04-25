import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { NgRedux } from 'ng2-redux';

import { IAppState } from '../';
import { USER_LOADING, USER_LOADED, USER_CLEAR } from './user.constants';
import { UserService, UserInfo } from '../../user';

@Injectable()
export class UserActions {

    private ngRedux: NgRedux<IAppState>;
    private userService: UserService;

    constructor(ngRedux: NgRedux<IAppState>, userService: UserService) {
        this.ngRedux = ngRedux;
        this.userService = userService;
    }

    public getUserInfo(): any {
        this.ngRedux.dispatch({ type: USER_LOADING });
        return this.userService.getUserInfo().map((userInfo: UserInfo) => {
            return this.ngRedux.dispatch({
                type: USER_LOADED,
                payload: userInfo
            });
        });
    }

    public clear(): any {
        return this.ngRedux.dispatch({ type: USER_CLEAR });
    }
}