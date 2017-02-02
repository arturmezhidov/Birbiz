import { NgModule } from "@angular/core";
import { AuctionRouting } from "./auction.routing";
import { AuctionContainer } from "./auction.container";

@NgModule({
    imports: [AuctionRouting],
    declarations: [AuctionContainer]
})
export class AuctionModule { }