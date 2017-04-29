import { NgModule } from '@angular/core';

import { ActiveBackgroundDirective } from './active-background/active-background.directive';

@NgModule({
    declarations: [ActiveBackgroundDirective],
    exports: [ActiveBackgroundDirective]
})
export class SharedDirectivesModule { }