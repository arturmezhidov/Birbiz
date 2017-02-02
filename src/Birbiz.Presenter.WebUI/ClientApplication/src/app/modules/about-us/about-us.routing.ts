import { Routes, RouterModule } from "@angular/router";
import { AboutUsContainer } from "./about-us.container";

export const AboutUsRoutes: Routes = [
    {
        path: "",
        component: AboutUsContainer
    }
];

export const AboutUsRouting = RouterModule.forChild(AboutUsRoutes);