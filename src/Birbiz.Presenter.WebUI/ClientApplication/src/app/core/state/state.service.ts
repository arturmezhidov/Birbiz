import { Injectable } from '@angular/core';
import { NgRedux } from 'ng2-redux';

import { IAppState, APP_INITIAL_STATE } from './app.state';
import { IUserState } from './user';

@Injectable()
export class StateService {

    private ngState: NgRedux<IAppState>;

    constructor(ngState: NgRedux<IAppState>) {
        this.ngState = ngState;
    }

    public getState(): IAppState {
        let state: IAppState = this.ngState.getState();
        if (!state) {
            state = APP_INITIAL_STATE;
        }
        return state;
    }

    public getUserState(): IUserState {
        return this.getState().user;
    }
}