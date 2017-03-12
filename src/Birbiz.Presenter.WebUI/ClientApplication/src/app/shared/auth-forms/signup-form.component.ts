import { Component } from '@angular/core';

import { AuthService, Register } from '../../core/auth';

@Component({
    selector: 'signup-form',
    templateUrl: './signup-form.component.html'
})
export class SignupFormComponent {

    model: Register = new Register();

    private authService: AuthService;

    constructor(authService: AuthService) {
        this.authService = authService;
    }

    onSubmit() {
        this.authService.register(this.model);
    }
}