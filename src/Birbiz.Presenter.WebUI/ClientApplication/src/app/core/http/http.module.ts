import { NgModule } from '@angular/core';
import { HttpModule as NgHttpModule } from '@angular/http';

import { StoragesModule } from '../storages';
import { HttpService } from './http.service';

@NgModule({
    imports: [NgHttpModule, StoragesModule],
    providers: [HttpService]
})
export class HttpModule { }