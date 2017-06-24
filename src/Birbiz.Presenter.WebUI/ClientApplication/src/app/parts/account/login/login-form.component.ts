import { Component } from '@angular/core';

import { AccountResources } from '../../../core/resx';
import { FormGroupEx, FormControlEx, CustomValidators } from '../../../core/forms';
import { Login, LoginErrors } from '../../../core/auth';
import { UserActions } from '../../../core/state/user';

@Component({
    selector: 'login-form',
    templateUrl: './login-form.component.html'
})
export class LoginFormComponent {

    public signinForm: FormGroupEx;
    public isBusy: boolean;

    private userActions: UserActions;

    constructor(userActions: UserActions) {
        this.userActions = userActions;
        this.signinForm = this.createForm();
        this.isBusy = false;
    }

    public onSubmit() {
        if (this.signinForm.valid) {
            this.submit();
        }
    }

    public onClear(): void {
        this.signinForm.reset();
    }

    private submit(): void {
        this.isBusy = true;
        let model: Login = this.signinForm.getModel<Login>();
        this.userActions.login(model).subscribe((e: any) => {
            this.signinForm.reset();
            this.isBusy = false;
        }, (loginErrors: LoginErrors) => {
            this.signinForm.extraErrors({
                login: loginErrors.loginError,
                password: loginErrors.passwordError
            });
            this.isBusy = false;
        });
    }

    private createForm(): FormGroupEx {

        // create login control
        let loginControl: FormControlEx = new FormControlEx('', [
            CustomValidators.required(AccountResources.loginRequired)
        ]);

        // create password control
        let passwordControl: FormControlEx = new FormControlEx('', [
            CustomValidators.required(AccountResources.passwordRequired)
        ]);

        // create remember me control
        let rememberMe: FormControlEx = new FormControlEx(false);

        // create form
        let form: FormGroupEx = new FormGroupEx({
            login: loginControl,
            password: passwordControl,
            rememberMe: rememberMe
        });

        return form;
    }
}