import { Component, Input } from '@angular/core';

import { IUserState } from '../../core/state/user';
import { AuthActions } from '../../core/state/auth';

@Component({
    selector: 'appbar-user',
    templateUrl: './appbar-user.component.html'
})
export class AppbarUserComponent {

    @Input() icon: string;
    @Input() user: IUserState;

    private authService: AuthActions;

    constructor(authService: AuthActions) {
        this.authService = authService;
    }

    public onLogout(): void {
        this.authService.logout();
    }
}