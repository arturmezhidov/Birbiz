import { Component, Input, AfterViewInit } from '@angular/core';
import { Subject, BehaviorSubject } from 'rxjs/Rx';

import { UserService, UserInfo } from '../../core/user';

@Component({
    selector: 'appbar-user',
    templateUrl: './appbar-user.component.html'
})
export class AppbarUserComponent implements AfterViewInit {

    @Input() icon: string;

    public userName: string;
    public isLoading: Subject<boolean>;

    private userService: UserService;

    constructor(userService: UserService) {
        this.userService = userService;
        this.isLoading = new BehaviorSubject(false);
    }

    public onLogout(): void {
        this.userService.logout();
    }

    ngAfterViewInit(): void {
        if (this.userService.isAuthenticated()) {
            this.isLoading.next(true);
            this.userService.getUserInfo().subscribe((userInfo: UserInfo) => {
                this.userName = userInfo.userName;
                this.isLoading.next(false);
            });
        }
    }
}