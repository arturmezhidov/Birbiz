﻿import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';

import { HttpService } from './http';
import { AuthService } from './auth';
import { TokenStorage } from './state/auth';
import { UserService } from './user';
import { ResourcesService } from './resx';

@NgModule({
    imports: [HttpModule],
    providers: [HttpService, AuthService, UserService, ResourcesService, TokenStorage]
})
export class CoreModule { }