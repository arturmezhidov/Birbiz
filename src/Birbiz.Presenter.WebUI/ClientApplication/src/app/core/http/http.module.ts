import { NgModule } from '@angular/core';
import { HttpModule as NgHttpModule } from '@angular/http';

import { HttpService } from './http.service';

@NgModule({
    imports: [NgHttpModule],
    providers: [HttpService]
})
export class HttpModule { }