import { RequestOptionsArgs } from '@angular/http';

export interface IRequestOptions {
    isSecure?: boolean;
    isForm?: boolean;
    args?: RequestOptionsArgs;
}