import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Http, Headers, Response, Request, RequestMethod, RequestOptions, RequestOptionsArgs } from '@angular/http';

import { TokenStorage, Token} from '../storages';

@Injectable()
export class HttpService {

    private http: Http;
    private tokenStorage: TokenStorage;

    constructor(http: Http, tokenStorage: TokenStorage) {
        this.http = http;
        this.tokenStorage = tokenStorage;
    }

    // GET

    public get<T>(url: string, options?: RequestOptionsArgs): Observable<T> {
        return this.query<T>({ url: url, method: RequestMethod.Get }, options);
    }

    public secureGet<T>(url: string, options?: RequestOptionsArgs): Observable<T> {
        return this.query<T>({ url: url, method: RequestMethod.Get }, options, true);
    }

    // POST

    public post<T>(url: string, body: any, options?: RequestOptionsArgs): Observable<T> {
        return this.query<T>({ url: url, body: body, method: RequestMethod.Post }, options);
    }

    public securePost<T>(url: string, body: any, options?: RequestOptionsArgs): Observable<T> {
        return this.query<T>({ url: url, body: body, method: RequestMethod.Post }, options, true);
    }

    public postForm<T>(url: string, body: any, options?: RequestOptionsArgs): Observable<T> {
        return this.query<T>({ url: url, body: body, method: RequestMethod.Post }, options, true, true);
    }

    // PUT

    public put<T>(url: string, body: any, options?: RequestOptionsArgs): Observable<T> {
        return this.query<T>({ url: url, body: body, method: RequestMethod.Put }, options);
    }

    public securePut<T>(url: string, body: any, options?: RequestOptionsArgs): Observable<T> {
        return this.query<T>({ url: url, body: body, method: RequestMethod.Put }, options, true);
    }

    public putForm<T>(url: string, body: any, options?: RequestOptionsArgs): Observable<T> {
        return this.query<T>({ url: url, body: body, method: RequestMethod.Put }, options, true, true);
    }

    // DELETE

    public delete<T>(url: string, options?: RequestOptionsArgs): Observable<T> {
        return this.query<T>({ url: url, method: RequestMethod.Delete }, options);
    }

    public secureDelete<T>(url: string, options?: RequestOptionsArgs): Observable<T> {
        return this.query<T>({ url: url, method: RequestMethod.Delete }, options, true);
    }

    // QUERY

    public query<T>(requestArgs: RequestOptionsArgs, additionalOptions?: RequestOptionsArgs, isSecure?: boolean, isForm?: boolean): Observable<T> {

        // create options
        let defaultOptions: RequestOptions = this.createRequestOptions(isSecure, isForm);
        let options: RequestOptions = this.mergeOptions(defaultOptions, requestArgs);
        let requestOptionsArgs: RequestOptionsArgs = this.mergeOptions(options, additionalOptions);

        // query
        let result: Observable<T> = this.http
            .request(requestOptionsArgs.url, requestOptionsArgs)
            .map(this.toJson);

        return result;
    }

    // Helpers

    private createRequestOptions(isSecure?: boolean, isForm?: boolean): RequestOptions {

        // headers
        let headers = new Headers();

        headers.append('Accept', 'application/json');

        if (isSecure) {
            headers.append('Authorization', 'Bearer ' + this.tokenStorage.getBearerToken());
        }

        if (isForm) {
            headers.append('Content-Type', 'application/x-www-form-urlencoded');
        } else {
            headers.append('Content-Type', 'application/json');
        }

        // request options
        let options: RequestOptions = new RequestOptions();

        options.headers = headers;
 
        return options;
    }

    private mergeOptions(options: RequestOptions, optionsArgs: RequestOptionsArgs) {

        if (options == null) {
            options = new RequestOptions();
        }

        if (optionsArgs != null) {
            options = options.merge(optionsArgs);
        }

        return options;
    }

    private toJson(response: Response) {
        return response.json();
    }
}