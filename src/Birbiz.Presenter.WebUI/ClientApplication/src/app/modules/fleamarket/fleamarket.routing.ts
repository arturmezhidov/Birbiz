import { Routes, RouterModule } from "@angular/router";
import { FleamarketContainer } from "./fleamarket.container";

export const FleamarketRoutes: Routes = [
    {
        path: "",
        component: FleamarketContainer
    }
];

export const FleamarketRouting = RouterModule.forChild(FleamarketRoutes);