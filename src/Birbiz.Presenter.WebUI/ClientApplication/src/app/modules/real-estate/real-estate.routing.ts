import { Routes, RouterModule } from "@angular/router";
import { RealEstateContainer } from "./real-estate.container";

export const RealEstateRoutes: Routes = [
    {
        path: "",
        component: RealEstateContainer
    }
];

export const RealEstateRouting = RouterModule.forChild(RealEstateRoutes);