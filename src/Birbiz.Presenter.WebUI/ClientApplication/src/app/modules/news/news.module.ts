import { NgModule } from "@angular/core";
import { NewsRouting } from "./news.routing";
import { NewsContainer } from "./news.container";

@NgModule({
    imports: [NewsRouting],
    declarations: [NewsContainer]
})
export class NewsModule { }