import { Routes, RouterModule } from "@angular/router";
import { ForumContainer } from "./forum.container";

export const ForumRoutes: Routes = [
    {
        path: "",
        component:ForumContainer
    }
];

export const ForumRouting = RouterModule.forChild(ForumRoutes);