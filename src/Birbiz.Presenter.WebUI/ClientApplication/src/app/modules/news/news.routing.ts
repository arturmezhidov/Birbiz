import { Routes, RouterModule } from "@angular/router";
import { NewsContainer } from "./news.container";

export const NewsRoutes: Routes = [
    {
        path: "",
        component: NewsContainer
    }
];

export const NewsRouting = RouterModule.forChild(NewsRoutes);