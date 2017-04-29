import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';  
import { RouterModule } from '@angular/router';

import { AuthFormsModule } from '../auth-forms';

import { AppbarComponent } from './appbar.component';
import { AppbarLogoComponent } from './appbar-logo.component';
import { AppbarDropdownComponent } from './appbar-dropdown.component';
import { AppbarUserComponent } from './appbar-user.component';

@NgModule({
    imports: [CommonModule, RouterModule, AuthFormsModule],
    declarations: [AppbarComponent, AppbarLogoComponent, AppbarDropdownComponent, AppbarUserComponent],
    exports: [AppbarComponent]
})
export class AppbarModule { }