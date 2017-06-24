import { Routes, RouterModule } from "@angular/router";
import { HomeContainer } from "./home.container";

export const HomeRoutes: Routes = [
    {
        path: "",
        component: HomeContainer
    }
];

export const HomeRouting = RouterModule.forChild(HomeRoutes);