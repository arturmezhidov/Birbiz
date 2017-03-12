import { NgModule } from '@angular/core';

import { HttpModule } from '../http';

import { AuthService } from './auth.service';
import { Login, Register } from './models';

@NgModule({
    imports: [HttpModule],
    providers: [AuthService]
})
export class AuthModule { }