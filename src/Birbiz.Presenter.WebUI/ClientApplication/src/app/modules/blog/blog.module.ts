import { NgModule } from "@angular/core";
import { BlogRouting } from "./blog.routing";
import { BlogContainer } from "./blog.container";

@NgModule({
    imports: [BlogRouting],
    declarations: [BlogContainer]
})
export class BlogModule { }