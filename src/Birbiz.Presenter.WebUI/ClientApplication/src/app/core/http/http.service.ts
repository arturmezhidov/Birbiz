import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Http, RequestMethod } from '@angular/http';

import { TokenService } from './token/token.service';
import { BaseHttpService } from './base-http.service';
import { IRequestOptions } from './request-options';

@Injectable()
export class HttpService extends BaseHttpService {

    constructor(http: Http, tokenService: TokenService) {
        super(http, tokenService);
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
}