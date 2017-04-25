import { NgModule } from '@angular/core';

import { AuthActions } from './auth';
import { UserActions } from './user';

@NgModule({
    providers: [AuthActions, UserActions]
})
export class StateModule { }