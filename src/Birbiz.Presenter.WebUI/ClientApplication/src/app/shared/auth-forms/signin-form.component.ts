﻿import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';


import { ResourcesService, ResourcesKeys } from '../../core/resx';
import { AuthService, Login, LoginResponse, LoginErrors } from '../../core/auth';

@Component({
    selector: 'signin-form',
    templateUrl: './signin-form.component.html'
})
export class SigninFormComponent {

    public signinForm: FormGroup;
    public errors: LoginErrors;
    public isBusy: boolean;

    private authService: AuthService;
    private resourcesService: ResourcesService;

    constructor(authService: AuthService, resourcesService: ResourcesService) {
        this.authService = authService;
        this.resourcesService = resourcesService;
        this.signinForm = this.createForm();
        this.errors = new LoginErrors();
        this.isBusy = false;
    }

    public onSubmit() {
        if (this.signinForm.valid) {
            this.submit();
        }
    }

    public onClear(): void {
        this.clearForm();
    }

    private submit(): void {
        this.isBusy = true;
        this.authService.login(<Login>this.signinForm.value).subscribe((response: LoginResponse) => {
            this.clearForm();
            this.isBusy = false;
        }, (errors: LoginErrors) => {
            this.errors = errors;
            this.isBusy = false;
        });
    }

    private createForm(): FormGroup {

        // create login control
        let loginControl: FormControl = new FormControl('', [Validators.required]);

        loginControl.statusChanges.subscribe((value: any) => {
            let error: string = '';
            if (loginControl.valid || !loginControl.dirty) {
                error = '';
            } else if (loginControl.hasError('required')) {
                error = this.resourcesService.get(ResourcesKeys.LoginRequired);
            }
            this.errors.loginError = error;
        });

        // create password control
        let passwordControl: FormControl = new FormControl('', [Validators.required]);

        passwordControl.statusChanges.subscribe((value: any) => {
            let error: string = '';
            if (passwordControl.valid || !passwordControl.dirty) {
                error = '';
            } else if (passwordControl.hasError('required')) {
                error = this.resourcesService.get(ResourcesKeys.PasswordRequired);
            }
            this.errors.passwordError = error;
        });

        // create remember me control
        let rememberMe: FormControl = new FormControl(false);

        // create form
        let form: FormGroup = new FormGroup({
            'login': loginControl,
            'password': passwordControl,
            'rememberMe': rememberMe
        });

        return form;
    }

    private clearForm(): void {
        this.errors.loginError = '';
        this.errors.passwordError = '';
        this.signinForm.reset();
    }
}