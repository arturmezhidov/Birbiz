import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Http, RequestMethod } from '@angular/http';
import { NgRedux } from 'ng2-redux';

import { IAppState } from '../state';
import { BaseHttpService } from './base-http.service';
import { IRequestOptions } from './request-options';

@Injectable()
export class HttpService extends BaseHttpService {

    private ngRedux: NgRedux<IAppState>;

    constructor(http: Http, ngRedux: NgRedux<IAppState>) {
        super(http);
        this.ngRedux = ngRedux;
    }

    public get<T>(url: string, options?: IRequestOptions): Observable<T> {
        return this.query<T>({ url: url, method: RequestMethod.Get }, options);
    }

    public post<T>(url: string, body: any, options?: IRequestOptions): Observable<T> {
        return this.query<T>({ url: url, body: body, method: RequestMethod.Post }, options);
    }
    
    public put<T>(url: string, body: any, options?: IRequestOptions): Observable<T> {
        return this.query<T>({ url: url, body: body, method: RequestMethod.Put }, options);
    }

    public delete<T>(url: string, options?: IRequestOptions): Observable<T> {
        return this.query<T>({ url: url, method: RequestMethod.Delete }, options);
    }

    protected getToken(): string {
        let state: IAppState = this.ngRedux.getState();
        return state.auth.token.accessToken;
    }
}