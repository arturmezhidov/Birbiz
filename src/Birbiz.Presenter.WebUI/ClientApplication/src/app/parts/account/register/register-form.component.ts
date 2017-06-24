import { Component } from '@angular/core';

import { AccountResources } from '../../../core/resx';
import { FormGroupEx, FormControlEx, CustomValidators } from '../../../core/forms';
import { AuthService, Register, Login, RegisterErrors, LoginErrors } from '../../../core/auth';
import { UserActions } from '../../../core/state/user';

@Component({
    selector: 'register-form',
    templateUrl: './register-form.component.html'
})
export class RegisterFormComponent {

    public signupForm: FormGroupEx;
    public isBusy: boolean;

    private authService: AuthService;
    private userActions: UserActions;

    constructor(authService: AuthService, userActions: UserActions) {
        this.authService = authService;
        this.userActions = userActions;
        this.signupForm = this.createForm();
        this.isBusy = false;
    }

    public onSubmit() {
        if (this.signupForm.valid) {
            this.submit();
        }
    }

    public onClear(): void {
        this.signupForm.reset();
    }

    private submit() {
        this.isBusy = true;
        let registerModel: Register = this.signupForm.getModel<Register>();
        this.authService.register(registerModel).subscribe(() => {
            this.signupForm.reset();
            let login: Login = new Login(
                registerModel.login,
                registerModel.password
            );
            this.userActions.login(login).subscribe(() => {
                this.isBusy = false;
            }, (loginErrors: LoginErrors) => {
                this.signupForm.extraErrors({
                    login: loginErrors.loginError,
                    password: loginErrors.passwordError
                });
                this.isBusy = false;
            });
        }, (errors: RegisterErrors) => {
            this.signupForm.extraErrors({
                login: errors.loginError,
                password: errors.passwordError,
                confirmPassword: errors.confirmPasswordError
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
            CustomValidators.required(AccountResources.passwordRequired),
            CustomValidators.minLength(AccountResources.passwordMinLength, 6),
            CustomValidators.maxLength(AccountResources.passwordMaxLength, 100),
            CustomValidators.digitRequired(AccountResources.passwordRequiresDigit),
            CustomValidators.lowerRequired(AccountResources.passwordRequiresLower),
            CustomValidators.upperRequired(AccountResources.passwordRequiresUpper),
        ]);

        // create confirm password control
        let confirmPasswordControl: FormControlEx = new FormControlEx('', [
            CustomValidators.required(AccountResources.passwordConfirmRequired),
            CustomValidators.equal(AccountResources.passwordUnequal, ['password'])
        ]);

        // create form
        let form: FormGroupEx = new FormGroupEx({
            login: loginControl,
            password: passwordControl,
            confirmPassword: confirmPasswordControl
        });

        return form;
    }
}