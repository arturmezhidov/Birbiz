import { NgModule } from "@angular/core";
import { DashboardRouting } from "./dashboard.routing";
import { DashboardContainer } from "./dashboard.container";

@NgModule({
    imports: [DashboardRouting],
    declarations: [DashboardContainer]
})
export class DashboardModule { }