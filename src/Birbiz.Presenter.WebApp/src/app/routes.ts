import { Routes } from '@angular/router';

import { HomeContainer, AboutUsContainer } from './shared/containers/index';

export const AppRoutes: Routes = [
    { path: '', component: HomeContainer },
    { path: 'about', component: AboutUsContainer },
    { path: '**', component: HomeContainer }
];