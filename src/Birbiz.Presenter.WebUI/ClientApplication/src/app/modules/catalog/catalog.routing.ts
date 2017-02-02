import { Routes, RouterModule } from "@angular/router";
import { CatalogContainer } from "./catalog.container";

export const CatalogRoutes: Routes = [
    {
        path: "",
        component: CatalogContainer
    }
];

export const CatalogRouting = RouterModule.forChild(CatalogRoutes);