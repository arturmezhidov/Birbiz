import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';

import { Http, Headers, Response, Request, RequestMethod, RequestOptions, RequestOptionsArgs } from '@angular/http';

@Injectable()
export class HttpService {

    protected http: Http;
    protected headers: Headers;
    protected options: RequestOptions;

    constructor(http: Http) {
        this.http = http;
        this.headers = new Headers({
            'Content-Type': 'application/json',
            Accept: 'application/json'
        });
        this.options = new RequestOptions({ headers: this.headers });
    }

    get<T>(url: string): Observable<T> {
        let result: Observable<T> = this.query<T>(url, { body: '', method: RequestMethod.Get });
        return result;
    }

    post<T>(url: string, body: any): Observable<T> {
        let result: Observable<T> = this.query<T>(url, { body: body, method: RequestMethod.Post });
        return result;
    }

    put<T>(url: string, body: any): Observable<T> {
        let result: Observable<T> = this.query<T>(url, { body: body, method: RequestMethod.Put });
        return result;
    }

    delete<T>(url: string): Observable<T> {
        let result: Observable<T> = this.query<T>(url, { body: '', method: RequestMethod.Delete } );
        return result;
    }

    protected query<T>(url: string, requestArgs: RequestOptionsArgs): Observable<T> {

        let result: Observable<T> = this.http
            .request(url, requestArgs)
            .map(this.checkForError)
            .catch(this.handleError)
            .map(this.toJson);

        return result;
    }

    private toJson(response: Response) {
        return response.json();
    }

    private handleError(error: any): Observable<Response> {
        return Observable.throw(error);
    }

    private checkForError(response: Response): Response {
        if (response.status >= 200 && response.status < 300) {
            return response;
        } else {
            var error = new Error(response.statusText);
            error['response'] = response;
            throw error;
        }
    }
}