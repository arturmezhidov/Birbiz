import { Routes, RouterModule } from "@angular/router";
import { AdminDashboardContainer } from "./admin-dashboard.container";

export const AdminDashboardRoutes: Routes = [
    {
        path: "",
        component: AdminDashboardContainer
    }
];

export const AdminDashboardRouting = RouterModule.forChild(AdminDashboardRoutes);