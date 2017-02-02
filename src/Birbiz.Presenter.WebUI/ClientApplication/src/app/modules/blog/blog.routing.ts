import { Routes, RouterModule } from "@angular/router";
import { BlogContainer } from "./blog.container";

export const BlogRoutes: Routes = [
    {
        path: "",
        component: BlogContainer
    }
];

export const BlogRouting = RouterModule.forChild(BlogRoutes);