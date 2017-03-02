import { NgModule } from "@angular/core";
import { RealEstateRouting } from "./real-estate.routing";
import { RealEstateContainer } from "./real-estate.container";

@NgModule({
    imports: [RealEstateRouting],
    declarations: [RealEstateContainer]
})
export class RealEstateModule { }