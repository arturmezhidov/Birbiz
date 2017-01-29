import { Routes } from '@angular/router';

import { HomeContainer } from './shared/containers/index';

export const AppRoutes: Routes = [
    { path: '', component: HomeContainer },
    { path: "dashboard", loadChildren: "es6-promise!./modules/dashboard/dashboard.module#DashboardModule" },
    { path: '**', component: HomeContainer }
];