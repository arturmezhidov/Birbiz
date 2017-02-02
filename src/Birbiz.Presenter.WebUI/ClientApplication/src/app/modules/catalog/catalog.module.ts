import { NgModule } from "@angular/core";
import { CatalogRouting } from "./catalog.routing";
import { CatalogContainer } from "./catalog.container";

@NgModule({
    imports: [CatalogRouting],
    declarations: [CatalogContainer]
})
export class CatalogModule { }