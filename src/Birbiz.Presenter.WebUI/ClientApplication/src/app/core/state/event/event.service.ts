import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { NgRedux } from 'ng2-redux';

import { IAppState } from '../app.state';
import { IEventState } from './event.state';

@Injectable()
export class EventService {

    private ngRedux: NgRedux<IAppState>;

    constructor(ngRedux: NgRedux<IAppState>) {
        this.ngRedux = ngRedux;
    }

    public getEventState(): IEventState {
        return this.ngRedux.getState().event;
    }

    public watch(action: string): Observable<any> {
        return this.ngRedux
            .select((state: IAppState) => state.event)
            .filter((event: IEventState) => {
                return event.action === action;
            })
            .map((event: IEventState) => {
                return event.data;
            });
    }
}