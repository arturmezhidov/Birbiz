import { NgModule }      from '@angular/core';
import { RouterModule } from '@angular/router';

import { NavbarComponent }   from './navbar.component';
import { NavbarItemComponent } from './navbar-item.component';
import { NavbarLogoComponent } from './navbar-logo.component';

@NgModule({
    imports: [RouterModule],
    declarations: [NavbarComponent, NavbarItemComponent, NavbarLogoComponent],
    exports: [NavbarComponent]
})
export class NavbarModule { }