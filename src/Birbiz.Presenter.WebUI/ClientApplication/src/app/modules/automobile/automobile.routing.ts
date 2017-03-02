import { Routes, RouterModule } from "@angular/router";
import { AutomobileContainer } from "./automobile.container";

export const AutomobileRoutes: Routes = [
    {
        path: "",
        component: AutomobileContainer
    }
];

export const AutomobileRouting = RouterModule.forChild(AutomobileRoutes);