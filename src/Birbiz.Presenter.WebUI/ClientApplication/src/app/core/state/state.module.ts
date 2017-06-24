import { NgModule } from '@angular/core';

import { StateService } from './state.service';
import { UserActions } from './user';
import { EventActions, EventService } from './event';

@NgModule({
    providers: [
        StateService,
        UserActions,
        EventActions,
        EventService
    ]
})
export class StateModule { }