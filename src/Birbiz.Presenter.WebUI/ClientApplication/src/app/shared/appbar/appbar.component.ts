import { Component, Input } from '@angular/core';

import { UserService } from '../../core/user';

@Component({
    selector: 'appbar',
    templateUrl: './appbar.component.html'
})
export class AppbarComponent {

    private userService: UserService;

    constructor(userService: UserService) {
        this.userService = userService;
    }

    public isAuthenticated() {
        return this.userService.isAuthenticated();
    }
}