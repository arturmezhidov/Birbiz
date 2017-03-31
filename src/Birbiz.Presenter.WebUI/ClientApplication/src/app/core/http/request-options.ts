import { RequestOptionsArgs } from '@angular/http';
import { Token } from './token/token';

export interface IRequestOptions {
    isSecure?: boolean;
    isForm?: boolean;
    args?: RequestOptionsArgs;
    token?: Token;
}