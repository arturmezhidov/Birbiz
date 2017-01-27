import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule }   from '@angular/forms';
import { RouterModule } from '@angular/router';

import { HomeContainer, AboutUsContainer }   from './shared/containers';
import { NavbarModule }   from './shared/components';
import { AppComponent }   from './app.component';
import { AppRoutes }   from './routes';

@NgModule({
    imports: [BrowserModule, FormsModule, RouterModule.forRoot(AppRoutes), NavbarModule],
    declarations: [AppComponent, HomeContainer, AboutUsContainer],
    bootstrap: [AppComponent]
})
export class AppModule { }