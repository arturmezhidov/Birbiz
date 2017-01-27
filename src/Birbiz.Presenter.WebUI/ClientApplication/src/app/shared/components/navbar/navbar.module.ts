import { NgModule }      from '@angular/core';
import { RouterModule } from '@angular/router';

import { NavbarComponent }   from './navbar.component';
import { NavbarItemComponent }   from './navbar-item.component';

@NgModule({
    imports: [RouterModule],
    declarations: [NavbarComponent, NavbarItemComponent],
    exports: [NavbarComponent]
})
export class NavbarModule { }