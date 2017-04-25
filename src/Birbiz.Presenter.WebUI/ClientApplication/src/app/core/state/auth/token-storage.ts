import { Injectable } from '@angular/core';
import { Token } from '../../auth';

interface IStorageAdapter {
    setItem(key: string, data: string): void;
    getItem(key: string): string;
    removeItem(key: string): void;
} 

@Injectable()
export class TokenStorage {

    private itemKey: string;
    private storage: IStorageAdapter;

    constructor() {
        this.itemKey = '___token';
        this.storage = localStorage;
    }

    public getToken(): Token {
        let token: Token = this.get<Token>(this.itemKey);
        return token;
    }

    public setToken(token: Token): void {
        this.set<Token>(this.itemKey, token);
    }

    public removeToken(): void {
        this.remove(this.itemKey);
    }

    public hasToken(): boolean {
        let result = this.getToken() != null;
        return result;
    }

    private set<T>(key: string, data: T): void {
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