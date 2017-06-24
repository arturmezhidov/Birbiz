import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs/Subscription';
import { NgRedux } from 'ng2-redux';

import { NavigatorService } from './core/routing';
import { IAppState } from './core/state';
import { UserActions, LOGIN_USER_SUCCESS, LOGOUT_USER, SCREEN_LOCK } from './core/state/user';
import { EventActions, EventService } from './core/state/event';
import { UserInfo } from './core/user';
import { TokenStorage, Token } from './core/auth';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    host: {
        '(document:click)': 'onClick($event)'
    }
})
export class AppComponent implements OnInit, OnDestroy {

    private userLoginSubcription: Subscription;
    private userLogoutSubcription: Subscription;
    private lockScreenSubcription: Subscription;
    private eventSubcription: Subscription;

    constructor(
        private navigator: NavigatorService,
        private ngRedux: NgRedux<IAppState>,
        private userActions: UserActions,
        private eventActions: EventActions,
        private eventService: EventService,
        private tokenStorage: TokenStorage) {
    }

    ngOnInit(): void {
        this.eventSubcription = this.eventService.watch(LOGIN_USER_SUCCESS).subscribe((token: Token) => {
            this.tokenStorage.setToken(token);
            this.unsubscribe(this.userLoginSubcription);
            this.userLoginSubcription = this.userActions.loadUserInfo().subscribe((actionResult: any) => {
                let userInfo: UserInfo = <UserInfo>actionResult.payload;
                if (userInfo.isAdminDashboardAvailable) {
                    this.navigator.goAdminDashboard();
                }
            });
        });
        this.userLogoutSubcription = this.eventService.watch(LOGOUT_USER).subscribe(() => {
            this.navigator.goLogin();
        });
        this.lockScreenSubcription = this.eventService.watch(SCREEN_LOCK).subscribe(() => {
            this.navigator.goLockScreen();
        });
    }

    ngOnDestroy(): void {
        this.unsubscribe(this.userLoginSubcription);
        this.unsubscribe(this.userLogoutSubcription);
        this.unsubscribe(this.lockScreenSubcription);
        this.unsubscribe(this.eventSubcription);
    }

    onClick(event: any): void {
        this.eventActions.documentClick(event);
    }

    private unsubscribe(subscription: Subscription): void {
        if (subscription && !subscription.closed) {
            subscription.unsubscribe();
        }
    }
}