import { Routes, RouterModule } from "@angular/router";
import { DashboardContainer } from "./dashboard.container";

export const DashboardRoutes: Routes = [
    {
        path: "",
        component: DashboardContainer
    }
];

export const DashboardRouting = RouterModule.forChild(DashboardRoutes);