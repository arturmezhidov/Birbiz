import { NgModule } from "@angular/core";
import { AboutUsRouting } from "./about-us.routing";
import { AboutUsContainer } from "./about-us.container";

@NgModule({
    imports: [AboutUsRouting],
    declarations: [AboutUsContainer]
})
export class AboutUsModule { }