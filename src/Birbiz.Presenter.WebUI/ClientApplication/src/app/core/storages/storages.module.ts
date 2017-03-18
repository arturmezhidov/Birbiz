import { NgModule } from '@angular/core';

import { Token, TokenStorage } from './token-storage.service';

@NgModule({
    providers: [Token, TokenStorage]
})
export class StoragesModule { }