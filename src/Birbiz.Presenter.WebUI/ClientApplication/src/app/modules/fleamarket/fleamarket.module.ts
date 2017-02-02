import { NgModule } from "@angular/core";
import { FleamarketRouting } from "./fleamarket.routing";
import { FleamarketContainer } from "./fleamarket.container";

@NgModule({
    imports: [FleamarketRouting],
    declarations: [FleamarketContainer]
})
export class FleamarketModule { }