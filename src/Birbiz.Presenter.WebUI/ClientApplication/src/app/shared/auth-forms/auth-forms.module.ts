import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AuthModule } from '../../core/auth';

import { SigninFormComponent } from './signin-form.component';
import { SignupFormComponent } from './signup-form.component';

@NgModule({
    imports: [FormsModule, AuthModule],
    declarations: [SignupFormComponent, SigninFormComponent],
    exports: [SignupFormComponent, SigninFormComponent]
})
export class AuthFormsModule { }