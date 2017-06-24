import { Component } from '@angular/core';
import { select } from 'ng2-redux';

import { IUserState } from '../../../core/state/user';

@Component({
    selector: 'lock-screen-container',
    templateUrl: './lock-screen.container.html'
})
export class LockScreenContainer {

    @select()
    public user$: IUserState;
}