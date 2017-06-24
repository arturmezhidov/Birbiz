import { Routes, RouterModule } from "@angular/router";
import { AdminContainer } from "./admin.container";

export const AdminRoutes: Routes = [
    {
        path: "",
        component: AdminContainer
    }
];

export const AdminRouting = RouterModule.forChild(AdminRoutes);