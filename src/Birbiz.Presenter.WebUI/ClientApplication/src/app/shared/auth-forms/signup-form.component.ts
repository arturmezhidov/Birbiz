import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

import { CustomValidators } from '../../core/forms';
import { ResourcesService, ResourcesKeys } from '../../core/resx';
import { AuthService, Register, RegisterResponse, RegisterErrors, Login, LoginResponse, LoginErrors } from '../../core/auth';

@Component({
    selector: 'signup-form',
    templateUrl: './signup-form.component.html'
})
export class SignupFormComponent {

    public signupForm: FormGroup;
    public errors: RegisterErrors;
    public isBusy: boolean;

    private authService: AuthService;
    private resourcesService: ResourcesService;

    constructor(authService: AuthService, resourcesService: ResourcesService) {
        this.authService = authService;
        this.resourcesService = resourcesService;
        this.signupForm = this.createForm();
        this.errors = new RegisterErrors();
        this.isBusy = false;
    }

    public onSubmit() {
        if (this.signupForm.valid) {
            this.submit();
        }
    }

    public onClear(): void {
        this.clearForm();
    }

    private submit() {
        this.isBusy = true;
        let registerModel: Register = <Register>this.signupForm.value;
        this.authService.register(registerModel).subscribe((response: RegisterResponse) => {
            this.clearForm();
            let login: Login = this.convertToLoginModel(registerModel);
            this.authService.login(login).subscribe((loginResponse: LoginResponse) => {
                this.isBusy = false;
            }, (loginErrors: LoginErrors) => {
                this.errors.loginError = loginErrors.loginError;
                this.isBusy = false;
            });
        }, (errors: RegisterErrors) => {
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
        let passwordControl: FormControl = new FormControl('', [
            Validators.required,
            Validators.minLength(6),
            Validators.maxLength(100),
            CustomValidators.digitRequired,
            CustomValidators.lowerRequired,
            CustomValidators.upperRequired
        ]);

        passwordControl.statusChanges.subscribe((value: any) => {
            let error: string = '';
            if (passwordControl.valid || !passwordControl.dirty) {
                error = '';
            } else if (passwordControl.hasError('required')) {
                error = this.resourcesService.get(ResourcesKeys.PasswordRequired);
            } else if (passwordControl.hasError('minlength')) {
                error = this.resourcesService.get(ResourcesKeys.PasswordMinLength);
            } else if (passwordControl.hasError('maxlength')) {
                error = this.resourcesService.get(ResourcesKeys.PasswordMaxLength);
            } else if (passwordControl.hasError('digitRequired')) {
                error = this.resourcesService.get(ResourcesKeys.PasswordRequiresDigit);
            } else if (passwordControl.hasError('lowerRequired')) {
                error = this.resourcesService.get(ResourcesKeys.PasswordRequiresLower);
            } else if (passwordControl.hasError('upperRequired')) {
                error = this.resourcesService.get(ResourcesKeys.PasswordRequiresUpper);
            }
            this.errors.passwordError = error;
        });

        // create confirm password control
        let confirmPasswordControl: FormControl = new FormControl('');

        // create form
        let form: FormGroup = new FormGroup({
            'login': loginControl,
            'password': passwordControl,
            'confirmPassword': confirmPasswordControl
        }, CustomValidators.equal(['password', 'confirmPassword']));

        form.statusChanges.subscribe((value: any) => {
            let error: string = '';
            if (form.hasError('equal')) {
                error = this.resourcesService.get(ResourcesKeys.PasswordUnequal);
            }
            this.errors.confirmPasswordError = error;
        });

        return form;
    }

    private clearForm(): void {
        this.errors.loginError = '';
        this.errors.passwordError = '';
        this.errors.confirmPasswordError = '';
        this.signupForm.reset();
    }

    private convertToLoginModel(model: Register): Login {
        let login: Login = new Login();
        login.login = model.login;
        login.password = model.password;
        return login;
    }
}