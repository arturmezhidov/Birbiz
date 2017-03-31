import { Token } from './token';

interface IStorageAdapter {
    setItem(key: string, data: string): void;
    getItem(key: string): string;
    removeItem(key: string): void;
} 

export abstract class TokenStorage {

    private itemKey: string;
    private storage: IStorageAdapter;
    private currentItem: Token = null;

    constructor(storage: IStorageAdapter, itemKey: string) {
        this.storage = storage;
        this.itemKey = itemKey;
        this.currentItem = this.getToken();
    }

    public getToken(): Token {
        if (this.currentItem == null) {
            this.currentItem = this.get<Token>(this.itemKey);
        }
        return this.currentItem;
    }

    public setToken(token: Token): void {
        this.currentItem = token;
        this.set<Token>(this.itemKey, token);
    }

    public removeToken(): void {
        this.currentItem = null;
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