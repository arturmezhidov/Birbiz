import { NgModule } from '@angular/core';

import { SigninFormComponent } from './signin-form.component';
import { SignupFormComponent } from './signup-form.component';

@NgModule({
    declarations: [SignupFormComponent, SigninFormComponent],
    exports: [SignupFormComponent, SigninFormComponent]
})
export class AuthModule { }