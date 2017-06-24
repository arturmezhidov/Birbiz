import { NgModule } from "@angular/core";
import { HomeRouting } from "./home.routing";
import { HomeContainer } from "./home.container";

@NgModule({
    imports: [HomeRouting],
    declarations: [HomeContainer]
})
export class HomeModule { }