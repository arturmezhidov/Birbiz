import { NgModule } from '@angular/core';

import { HttpModule } from '../http';
import { AuthModule } from '../auth';
import { UserService } from './user.service';

@NgModule({
    imports: [HttpModule, AuthModule],
    providers: [UserService]
})
export class UserModule { }