import { Injectable } from '@angular/core';

import { Token } from './token';
import { TokenStorage } from './token-storage';

@Injectable()
export class TokenService extends TokenStorage {

    constructor() {
        super(localStorage, '___token');
    }

    public getAccessToken(): string {
        let token: Token = this.getToken();
        if (token == null) {
            return "";
        }
        return token.access_token;
    }

    public getBearerToken(): string {
        let token: Token = this.getToken();
        if (token == null) {
            return "";
        }
        return token.access_token;
    }

    public getBearerTokenFrom(token: Token): string {
        if (token == null) {
            return "";
        }
        return token.access_token;
    }

    public getExpiresIn(): string {
        let token: Token = this.getToken();
        if (token == null) {
            return "";
        }
        // TODO: implement meaningful refresh, handle expiry 
        return token.expires_in.toString();
    }
}