import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { NgRedux, NgReduxModule } from 'ng2-redux';

import { HttpService } from './http';
import { AuthService, TokenStorage } from './auth';
import { UserService } from './user';
import { StateModule, configureStore, IAppState } from './state';
import { AdminDashboardGuard, NavigatorService } from './routing';

@NgModule({
    imports: [
        HttpModule,
        NgReduxModule,
        StateModule
    ],
    providers: [
        HttpService,
        AuthService,
        TokenStorage,
        UserService,
        AdminDashboardGuard,
        NavigatorService
    ]
})
export class CoreModule {
    constructor(ngRedux: NgRedux<IAppState>) {
        configureStore(ngRedux);
    }
}