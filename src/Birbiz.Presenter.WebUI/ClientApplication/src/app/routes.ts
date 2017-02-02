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
        path: "fleamarket",
        loadChildren: "es6-promise!./modules/fleamarket/fleamarket.module#FleamarketModule"
    },
    {
        path: "auction",
        loadChildren: "es6-promise!./modules/auction/auction.module#AuctionModule"
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
        path: 'aboutus',
        loadChildren: "es6-promise!./modules/about-us/about-us.module#AboutUsModule"
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