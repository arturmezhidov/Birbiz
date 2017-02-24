import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { HomeModule } from './modules/home/home.module';
import { AuthModule, AppbarModule } from './shared';
import { AppComponent } from './app.component';
import { AppRoutes } from './routes';

@NgModule({
    imports: [BrowserModule, FormsModule, RouterModule.forRoot(AppRoutes), AuthModule, AppbarModule, HomeModule],
    declarations: [AppComponent],
    bootstrap: [AppComponent]
})
export class AppModule { } 