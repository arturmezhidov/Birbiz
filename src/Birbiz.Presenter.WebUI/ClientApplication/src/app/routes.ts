import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AdminDashboardGuard } from './core/routing';

export const AppRoutes: Routes = [
    {
        path: '',
        //loadChildren: "es6-promise!./parts/home/home.module#HomeModule"
        redirectTo: 'admin',
        pathMatch: 'full'
    },
    {
        path: "account",
        loadChildren: "es6-promise!./parts/account/account.module#AccountModule"
    },
    {
        path: "admin",
        loadChildren: "es6-promise!./parts/admin/admin.module#AdminModule",
        canActivate: [AdminDashboardGuard]
    },
    {
        path: '**',
        redirectTo: ''
    }
];

export const AppRouting: ModuleWithProviders = RouterModule.forRoot(AppRoutes);