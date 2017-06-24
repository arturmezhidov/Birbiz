import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { ControlsModule } from '../controls/controls.module';

import {
    HeaderComponent,
    HeaderLogoComponent,
    HeaderSearchComponent
} from './header';

import {
    TopMenuComponent
} from './top-menu';

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
        ControlsModule
    ],
    declarations: [
        HeaderComponent,
        HeaderLogoComponent,
        HeaderSearchComponent,
        TopMenuComponent
    ],
    exports: [
        HeaderComponent,
        HeaderLogoComponent,
        HeaderSearchComponent,
        TopMenuComponent
    ]
})
export class LayoutModule { }