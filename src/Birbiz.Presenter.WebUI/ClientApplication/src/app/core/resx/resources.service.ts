import { Injectable } from '@angular/core';
import { ResourcesKeys } from './resources-keys';

@Injectable()
export class ResourcesService  {

    private resources: any = new Object();

    constructor() {
        this.init();
    }

    get(key: ResourcesKeys): string {
        let value: string = this.resources[key] || '';
        return value;
    }

    // TODO: load resources from server
    private init(): void {
        // auth resources
        this.resources[ResourcesKeys.LoginRequired] = 'Пожалуйста, введите логин.';
        this.resources[ResourcesKeys.PasswordRequired] = 'Пожалуйста, введите пароль.';
        this.resources[ResourcesKeys.PasswordUnequal] = 'Пароли не совпадают.';
        this.resources[ResourcesKeys.PasswordMinLength] = 'Длина пароля должна быть не менее 6 символов.';
        this.resources[ResourcesKeys.PasswordMaxLength] = 'Длина пароля должна быть не более 100 символов.';
        this.resources[ResourcesKeys.PasswordRequiresDigit] = 'Пароль должен содержать хоть одну цифру.';
        this.resources[ResourcesKeys.PasswordRequiresLower] = 'Пароль должен содержать хоть одну маленькую букву.';
        this.resources[ResourcesKeys.PasswordRequiresUpper] = 'Пароль должен содержать хоть одну большую букву.';
        this.resources[ResourcesKeys.PasswordRequiresNonAlphanumeric] = 'Пароль должен содержать хоть один небуквенный символ.';
    }
}