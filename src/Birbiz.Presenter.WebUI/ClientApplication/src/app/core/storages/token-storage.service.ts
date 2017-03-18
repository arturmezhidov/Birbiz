import { Injectable } from '@angular/core';
import { IStorage } from './IStorage';

export class Token {
    public access_token: string;
    public expires_in: number;
    public refresh_token: string;
    public token_type: string;
}

@Injectable()
export class TokenStorage {

    private storage: IStorage = localStorage;
    private tokenKey: string = "___token";
    private currentToken: Token = null;

    constructor() {
        this.currentToken = this.getToken();
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

    public getExpiresIn(): string {
        let token: Token = this.getToken();
        if (token == null) {
            return "";
        }
        // TODO: implement meaningful refresh, handle expiry 
        return token.expires_in.toString();
    }

    public getToken(): Token {
        if (this.currentToken == null) {
            this.currentToken = this.get<Token>(this.tokenKey);
        }
        return this.currentToken;
    }

    public setToken(token: Token): void {
        this.currentToken = token;
        this.set(this.tokenKey, token);
    }

    public removeToken(): void {
        this.currentToken = null;
        this.remove(this.tokenKey);
    }

    public hasToken(): boolean {
        let result = this.getToken() != null;
        return result;
    }

    private set(key: string, data: any): void {
        let json: string = JSON.stringify(data);
        this.storage.setItem(key, json);
    }

    private get<T>(key: string): T {
        let json: string = this.storage.getItem(key);
        let data: T = JSON.parse(json);
        return data;
    }

    private remove(key: string): void {
        this.storage.removeItem(key);
    }
}