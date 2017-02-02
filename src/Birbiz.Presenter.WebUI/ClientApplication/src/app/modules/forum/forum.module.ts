import { NgModule } from "@angular/core";
import { ForumRouting } from "./forum.routing";
import { ForumContainer } from "./forum.container";

@NgModule({
    imports: [ForumRouting],
    declarations: [ForumContainer]
})
export class ForumModule { }