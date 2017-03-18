export interface IStorage {
    setItem(key: string, data: string): void;
    getItem(key: string): string;
    removeItem(key: string): void;
} 