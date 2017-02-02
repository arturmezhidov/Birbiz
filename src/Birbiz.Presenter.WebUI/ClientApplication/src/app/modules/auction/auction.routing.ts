import { Routes, RouterModule } from "@angular/router";
import { AuctionContainer } from "./auction.container";

export const AuctionRoutes: Routes = [
    {
        path: "",
        component: AuctionContainer
    }
];

export const AuctionRouting = RouterModule.forChild(AuctionRoutes);