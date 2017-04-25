import { Component, Input } from '@angular/core';
import { Observable } from 'rxjs';
import { select } from 'ng2-redux';

import { IAuthState } from '../../core/state/auth';
import { IUserState } from '../../core/state/user';

@Component({
    selector: 'appbar',
    templateUrl: './appbar.component.html'
})
export class AppbarComponent {
    @select() auth$: Observable<IAuthState>;
    @select() user$: Observable<IUserState>;
}