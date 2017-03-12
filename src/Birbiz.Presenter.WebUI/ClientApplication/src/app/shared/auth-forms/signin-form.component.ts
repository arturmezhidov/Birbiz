import { Component } from '@angular/core';

import { AuthService, Login } from '../../core/auth';

@Component({
    selector: 'signin-form',
    templateUrl: './signin-form.component.html'
})
export class SigninFormComponent {

    model: Login = new Login();

    private authService: AuthService;

    constructor(authService: AuthService) {
        this.authService = authService;
    }

    onSubmit() {
       this.authService.login(this.model);
    }
}