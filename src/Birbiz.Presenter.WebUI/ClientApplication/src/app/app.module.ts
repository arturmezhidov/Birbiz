import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { NgRedux, NgReduxModule} from 'ng2-redux';

import { CoreModule } from './core/core.module';
import { StateModule, IAppState, APP_INITIAL_STATE, appReducer } from './core/state';
import { SharedComponents } from './shared';
import { HomeModule } from './modules/home/home.module';
import { AppComponent } from './app.component';
import { AppRoutes } from './routes';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        RouterModule.forRoot(AppRoutes),
        CoreModule,
        StateModule,
        SharedComponents,
        NgReduxModule,
        HomeModule],
    declarations: [AppComponent],
    bootstrap: [AppComponent]
})
export class AppModule {
    constructor(ngRedux: NgRedux<IAppState>) {
        ngRedux.configureStore(appReducer, APP_INITIAL_STATE);
    }
}