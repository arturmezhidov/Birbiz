import { Component } from '@angular/core';
import { select } from 'ng2-redux';

import { IUserState } from '../../../core/state/user';
import { INotificationsState } from '../../../core/state/notifications';
import { IMessagesState } from '../../../core/state/messages';
import { ITasksState } from '../../../core/state/tasks';

@Component({
    selector: 'admin-top-menu',
    templateUrl: './admin-top-menu.component.html'
})
export class AdminTopMenuComponent {

    @select()
    public user$: IUserState;

    @select()
    public notifications$: INotificationsState;

    @select()
    public messages$: IMessagesState;

    @select()
    public tasks$: ITasksState;
}