import { Inject } from '@angular/core';
import { CanActivate } from "@angular/router";

import { StateService } from '../state';
import { NavigatorService } from './navigator.service';

export class AdminDashboardGuard implements CanActivate {

    private state: StateService;
    private navigator: NavigatorService;

    constructor(
            @Inject(StateService) state: StateService,
            @Inject(NavigatorService) navigator: NavigatorService) {
        this.state = state;
        this.navigator = navigator;
    }

    canActivate(): boolean {
        let isAdminDashboardAvailable: boolean = this.state.getUserState().isAdminDashboardAvailable;
        if (!isAdminDashboardAvailable) {
            this.navigator.goLogin();
        }
        return isAdminDashboardAvailable;
    }
}