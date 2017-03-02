import { Routes } from '@angular/router';

import { HomeContainer } from './modules/home/home.container';

export const AppRoutes: Routes = [
    {
        path: '',
        component: HomeContainer
    },
    {
        path: "catalog",
        loadChildren: "es6-promise!./modules/catalog/catalog.module#CatalogModule"
    },
    {
        path: "auction",
        loadChildren: "es6-promise!./modules/auction/auction.module#AuctionModule"
    },
    {
        path: "automobile",
        loadChildren: "es6-promise!./modules/automobile/automobile.module#AutomobileModule"
    },
    {
        path: "real-estate",
        loadChildren: "es6-promise!./modules/real-estate/real-estate.module#RealEstateModule"
    },
    {
        path: "forum",
        loadChildren: "es6-promise!./modules/forum/forum.module#ForumModule"
    },
    {
        path: "blog",
        loadChildren: "es6-promise!./modules/blog/blog.module#BlogModule"
    },
    {
        path: "news",
        loadChildren: "es6-promise!./modules/news/news.module#NewsModule"
    },
    {
        path: "dashboard",
        loadChildren: "es6-promise!./modules/dashboard/dashboard.module#DashboardModule"
    },
    {
        path: '**',
        component: HomeContainer
    }
];