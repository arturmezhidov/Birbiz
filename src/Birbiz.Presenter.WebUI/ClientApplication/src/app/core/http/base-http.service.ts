import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Http, Headers, Response, RequestOptions, RequestOptionsArgs } from '@angular/http';

import { TokenService } from './token/token.service';
import { IRequestOptions } from './request-options';
import { ErrorResponse } from './error-response';

export abstract class BaseHttpService {

    protected http: Http;
    protected tokenService: TokenService;

    constructor(http: Http, tokenService: TokenService) {
        this.http = http;
        this.tokenService = tokenService;
    }

    protected query<T>(requestArgs: RequestOptionsArgs, additionalOptions?: IRequestOptions): Observable<any> {

        // create options
        let options: RequestOptions = this.createRequestOptions(additionalOptions);

        options = this.mergeOptions(options, requestArgs);

        if (additionalOptions && additionalOptions.args) {
            options = this.mergeOptions(options, additionalOptions.args);
        }

        // query
        let result: Observable<any> = this.http
            .request(options.url, options)
            .catch(this.handleError)
            .map(this.toJson);

        return result;
    }

    private createRequestOptions(options: IRequestOptions): RequestOptions {

        let headers = new Headers();

        headers.append('Accept', 'application/json');

        if (options) {

            if (options.isSecure) {

                let token: string = options.token
                    ? this.tokenService.getBearerTokenFrom(options.token)
                    : this.tokenService.getBearerToken();

                headers.append('Authorization', 'Bearer ' + token);
            }

            if (options.isForm) {
                headers.append('Content-Type', 'application/x-www-form-urlencoded');
            } else {
                headers.append('Content-Type', 'application/json');
            }
        }

        let requestOptions: RequestOptions = new RequestOptions();

        requestOptions.headers = headers;
 
        return requestOptions;
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

    private toJson(response: Response) : any {
        return response.json();
    }

    private handleError(response: Response): Observable<any> {
        let error: ErrorResponse = <ErrorResponse>response.json();
        return Observable.throw(error);
    }
}