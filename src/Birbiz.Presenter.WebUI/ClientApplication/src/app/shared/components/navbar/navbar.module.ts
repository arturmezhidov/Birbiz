import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { SharedDirectivesModule } from '../../directives';

import { NavbarComponent }   from './navbar.component';
import { NavbarItemComponent } from './navbar-item.component';

@NgModule({
    imports: [RouterModule, SharedDirectivesModule],
    declarations: [NavbarComponent, NavbarItemComponent],
    exports: [NavbarComponent]
})
export class NavbarModule { }