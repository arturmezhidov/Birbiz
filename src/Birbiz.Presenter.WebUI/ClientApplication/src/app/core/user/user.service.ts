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
        return this.http.get(HttpConfig.USERINFO_URL, { isSecure: true }).map((userInfo: UserInfo) => {
            userInfo.isAdminDashboardAvailable = this.checkAdminDashboardAvailability(userInfo.roles);
            return userInfo;
        });
    }

    private checkAdminDashboardAvailability(roles: any): boolean {
        if (roles) {
            let isAdminDashboardAvailable: boolean = roles.superadmin
                || roles.useradmin
                || roles.catalogadmin
                || roles.auctionadmin
                || roles.automobileadmin
                || roles.realestateadmin
                || roles.forumadmin
                || roles.blogadmin
                || roles.newsadmin
                || roles.commentmoderator;
            return isAdminDashboardAvailable;
        }
        return false;
    }
}