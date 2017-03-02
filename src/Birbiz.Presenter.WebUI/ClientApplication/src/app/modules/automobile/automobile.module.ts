import { NgModule } from "@angular/core";
import { AutomobileRouting } from "./automobile.routing";
import { AutomobileContainer } from "./automobile.container";

@NgModule({
    imports: [AutomobileRouting],
    declarations: [AutomobileContainer]
})
export class AutomobileModule { }