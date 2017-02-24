import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AuthModule } from '../auth/auth.module';
import { AppbarComponent } from './appbar.component';
import { AppbarLogoComponent } from './appbar-logo.component';
import { AppbarDropdownComponent } from './appbar-dropdown.component';

@NgModule({
    imports: [RouterModule, AuthModule],
    declarations: [AppbarComponent, AppbarLogoComponent, AppbarDropdownComponent],
    exports: [AppbarComponent]
})
export class AppbarModule { }