import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';

import { HttpConfig } from '../../config/http.config'
import { HttpService } from '../http';
import { UserInfo } from './user.models'

@Injectable()
export class UserService {

    private http: HttpService;

    constructor(http: HttpService) {
        this.http = http;
    }

    public getUserInfo(): Observable<UserInfo> {
        return this.http.get(HttpConfig.USERINFO_URL, { isSecure: true });
    }
}