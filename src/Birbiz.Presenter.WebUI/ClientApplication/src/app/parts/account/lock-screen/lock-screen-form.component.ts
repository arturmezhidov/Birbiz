import { Component, Input, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs/Subscription';

import { AccountResources } from '../../../core/resx';
import { Login, LoginErrors } from '../../../core/auth';
import { FormGroupEx, FormControlEx, CustomValidators } from '../../../core/forms';
import { IUserState, UserActions } from '../../../core/state/user';

@Component({
    selector: 'lock-screen-form',
    templateUrl: './lock-screen-form.component.html'
})
export class LockScreenFormComponent implements OnDestroy {

    @Input()
    public user: IUserState;

    public lockScreenForm: FormGroupEx;
    public isBusy: boolean;

    private userActions: UserActions;

    constructor(userActions: UserActions) {
        this.userActions = userActions;
        this.lockScreenForm = this.createForm();
        this.isBusy = false;
    }

    public onSubmit() {
        if (this.lockScreenForm.valid) {
            this.submit();
        }
    }

    public onClear(): void {
        this.lockScreenForm.reset();
    }

    ngOnDestroy(): void {
        
    }

    private submit(): void {
        this.isBusy = true;
        let model: Login = new Login(
            this.user.profile.userName,
            this.getPassword()
        );
        this.userActions.login(model).subscribe((e: any) => {
            this.lockScreenForm.reset();
            this.isBusy = false;
        }, (loginErrors: LoginErrors) => {
            this.lockScreenForm.extraErrors({
                password: loginErrors.passwordError || loginErrors.loginError
            });
            this.isBusy = false;
        });
    }

    private createForm(): FormGroupEx {

        // create password control
        let passwordControl: FormControlEx = new FormControlEx('', [
            CustomValidators.required(AccountResources.passwordRequired)
        ]);

        // create form
        let form: FormGroupEx = new FormGroupEx({
            password: passwordControl
        });

        return form;
    }

    private getPassword(): string {
        return <string>this.lockScreenForm.getControlValue('password');
    }
}