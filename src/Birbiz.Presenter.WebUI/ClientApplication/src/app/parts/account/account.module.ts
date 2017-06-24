import { NgModule } from "@angular/core";
import { ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';  

import { AccountRouting } from "./account.routing";
import { AccountContainer } from "./account.container";
import { LoginContainer } from "./login/login.container";
import { LoginFormComponent } from "./login/login-form.component";
import { RegisterContainer } from "./register/register.container";
import { RegisterFormComponent } from "./register/register-form.component";
import { ForgotPasswordContainer } from "./forgot-password/forgot-password.container";
import { ForgotPasswordFormComponent } from "./forgot-password/forgot-password-form.component";
import { LockScreenContainer } from "./lock-screen/lock-screen.container";
import { LockScreenFormComponent } from "./lock-screen/lock-screen-form.component";
import { LockAccountContainer } from "./lock-account/lock-account.container";

@NgModule({
    imports: [
        ReactiveFormsModule,
        CommonModule,
        AccountRouting
    ],
    declarations: [
        AccountContainer,
        LoginContainer,
        LoginFormComponent,
        RegisterContainer,
        RegisterFormComponent,
        ForgotPasswordContainer,
        ForgotPasswordFormComponent,
        LockScreenContainer,
        LockScreenFormComponent,
        LockAccountContainer
    ]
})
export class AccountModule { }