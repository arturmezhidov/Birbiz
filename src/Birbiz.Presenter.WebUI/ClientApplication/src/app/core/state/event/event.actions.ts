import { Injectable } from '@angular/core';
import { NgRedux } from 'ng2-redux';

import { IAppState } from '../';
import { DOCUMENT_CLICK } from './event.constants';

@Injectable()
export class EventActions {

    private ngRedux: NgRedux<IAppState>;

    constructor(ngRedux: NgRedux<IAppState>) {
        this.ngRedux = ngRedux;
    }

    public trigger(action: string, data?: any): any {
        return this.ngRedux.dispatch({
            type: action,
            payload: data || {}
        });
    }

    public documentClick(data: any): void {
        return this.trigger(DOCUMENT_CLICK, data);
    }
}