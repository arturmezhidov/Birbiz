import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';

import { LayoutModule } from '../../shared/layout/layout.module';

import { AdminRouting } from "./admin.routing";
import { AdminContainer } from "./admin.container";
import {
    AdminHeaderComponent,
    AdminTopMenuComponent
} from './layout';

@NgModule({
    imports: [
        CommonModule,
        LayoutModule,
        AdminRouting
    ],
    declarations: [
        AdminContainer,
        AdminHeaderComponent,
        AdminTopMenuComponent
    ]
})
export class AdminModule { }