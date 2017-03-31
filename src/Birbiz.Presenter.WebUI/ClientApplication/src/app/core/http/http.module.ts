import { NgModule } from '@angular/core';
import { HttpModule as NgHttpModule } from '@angular/http';

import { TokenService } from './index';
import { HttpService } from './http.service';

@NgModule({
    imports: [NgHttpModule],
    providers: [HttpService, TokenService]
})
export class HttpModule { }