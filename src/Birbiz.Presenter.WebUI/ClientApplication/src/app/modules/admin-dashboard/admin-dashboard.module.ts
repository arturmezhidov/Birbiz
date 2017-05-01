import { NgModule } from "@angular/core";
import { AdminDashboardRouting } from "./admin-dashboard.routing";
import { AdminDashboardContainer } from "./admin-dashboard.container";

@NgModule({
    imports: [AdminDashboardRouting],
    declarations: [AdminDashboardContainer]
})
export class AdminDashboardModule { }