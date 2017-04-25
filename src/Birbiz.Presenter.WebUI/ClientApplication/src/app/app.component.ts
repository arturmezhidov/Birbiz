import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs/Subscription';
import { NgRedux } from 'ng2-redux';

import { IAppState } from './core/state';
import { IAuthState, AuthActions, TokenStorage } from './core/state/auth';
import { UserActions } from './core/state/user';

@Component({
    selector: 'app',
    templateUrl: './app.component.html'
})
export class AppComponent implements OnInit, OnDestroy {

    private authSubcription: Subscription;

    constructor(
        private ngRedux: NgRedux<IAppState>,
        private userActions: UserActions,
        private authActions: AuthActions,
        private tokenStorage: TokenStorage) {
    }

    ngOnInit(): void {
        let token = this.tokenStorage.getToken();
        this.authSubcription = this.ngRedux.select((state: IAppState) => state.auth).subscribe((authState: IAuthState) => {
            if (!authState.isLoading) {
                if (authState.isAuthenticated) {
                    this.userActions.getUserInfo().subscribe((actionResult: any) => {
                        this.tokenStorage.setToken(authState.token);
                    });
                } else {
                    this.tokenStorage.removeToken();
                    this.userActions.clear();
                }
            }
        });
        if (token) {
            this.authActions.updateToken(token);
        }
    }

    ngOnDestroy(): void {
        this.authSubcription.unsubscribe();
    }
}