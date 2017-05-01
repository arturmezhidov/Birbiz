import { Component } from '@angular/core';
import { select } from 'ng2-redux';

import { IUserState } from '../../../core/state/user';
import { NavbarItemComponent } from './navbar-item.component';

@Component({
    selector: 'navbar',
    templateUrl: './navbar.component.html'
})
export class NavbarComponent {
    @select()
    public user$: IUserState;
}