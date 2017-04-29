import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { SigninFormComponent } from './signin-form.component';
import { SignupFormComponent } from './signup-form.component';

@NgModule({
    imports: [BrowserModule, ReactiveFormsModule],
    declarations: [SignupFormComponent, SigninFormComponent],
    exports: [SignupFormComponent, SigninFormComponent]
})
export class AuthFormsModule { }