import { Component } from '@angular/core';

import { AccountResources } from '../../../core/resx';
import { FormGroupEx, FormControlEx, CustomValidators } from '../../../core/forms';

@Component({
    selector: 'forgot-password-form',
    templateUrl: './forgot-password-form.component.html'
})
export class ForgotPasswordFormComponent {

    public passwordForgotForm: FormGroupEx;
    public isBusy: boolean;

    constructor() {
        this.passwordForgotForm = this.createForm();
        this.isBusy = false;
    }

    public onSubmit() {
        if (this.passwordForgotForm.valid) {
            this.submit();
        }
    }

    public onClear(): void {
        this.passwordForgotForm.reset();
    }

    private submit(): void {

    }

    private createForm(): FormGroupEx {

        // create email control
        let emailControl: FormControlEx = new FormControlEx('', [
            CustomValidators.required(AccountResources.emailRequired),
            CustomValidators.email(AccountResources.emailInvalid)
        ]);

        // create form
        let form: FormGroupEx = new FormGroupEx({
            email: emailControl
        });

        return form;
    }
}