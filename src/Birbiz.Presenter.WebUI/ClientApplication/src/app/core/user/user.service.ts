import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Observer } from 'rxjs/Observer';

import { HttpConfig } from '../../config/http.config'
import { HttpService } from '../http';
import { AuthService } from '../auth';
import { UserInfo } from './user-info'


@Injectable()
export class UserService {

    private http: HttpService;
    private authService: AuthService;

    constructor(http: HttpService, authService: AuthService) {
        this.http = http;
        this.authService = authService;
    }

    public getUserInfo(): Observable<UserInfo> {
        return this.http.get(HttpConfig.USERINFO_URL, { isSecure: true });
    }

    public isAuthenticated(): boolean {
        return this.authService.isLoggedIn();
    }

    public logout(): void {
        this.authService.logout();
    }
}