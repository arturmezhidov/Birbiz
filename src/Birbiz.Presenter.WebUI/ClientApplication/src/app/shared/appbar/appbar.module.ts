import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AuthFormsModule } from '../auth-forms';

import { AppbarComponent } from './appbar.component';
import { AppbarLogoComponent } from './appbar-logo.component';
import { AppbarDropdownComponent } from './appbar-dropdown.component';

@NgModule({
    imports: [RouterModule, AuthFormsModule],
    declarations: [AppbarComponent, AppbarLogoComponent, AppbarDropdownComponent],
    exports: [AppbarComponent]
})
export class AppbarModule { }