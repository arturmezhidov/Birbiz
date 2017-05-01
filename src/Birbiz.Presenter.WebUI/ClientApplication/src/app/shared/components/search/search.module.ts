import { NgModule } from '@angular/core';

import { SharedDirectivesModule } from '../../directives';
import { SearchComponent }   from './search.component';

@NgModule({
    imports: [SharedDirectivesModule],
    declarations: [SearchComponent],
    exports: [SearchComponent]
})
export class SearchModule { }