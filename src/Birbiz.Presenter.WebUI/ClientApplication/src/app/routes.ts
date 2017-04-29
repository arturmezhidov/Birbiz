import { Routes } from '@angular/router';

import { SystemColors } from './config/system-colors';
import { HomeContainer } from './modules/home/home.container';

export const AppRoutes: Routes = [
    {
        path: '',
        component: HomeContainer,
        data: {
            backgroundColor: SystemColors.BG_HOME
        }
    },
    {
        path: "catalog",
        loadChildren: "es6-promise!./modules/catalog/catalog.module#CatalogModule",
        data: {
            backgroundColor: SystemColors.BG_CATALOG
        }
    },
    {
        path: "auction",
        loadChildren: "es6-promise!./modules/auction/auction.module#AuctionModule",
        data: {
            backgroundColor: SystemColors.BG_AUCTION
        }
    },
    {
        path: "automobile",
        loadChildren: "es6-promise!./modules/automobile/automobile.module#AutomobileModule",
        data: {
            backgroundColor: SystemColors.BG_AUTOMOBILE
        }
    },
    {
        path: "real-estate",
        loadChildren: "es6-promise!./modules/real-estate/real-estate.module#RealEstateModule",
        data: {
            backgroundColor: SystemColors.BG_REAL_ESTATE
        }
    },
    {
        path: "forum",
        loadChildren: "es6-promise!./modules/forum/forum.module#ForumModule",
        data: {
            backgroundColor: SystemColors.BG_FORUM
        }
    },
    {
        path: "blog",
        loadChildren: "es6-promise!./modules/blog/blog.module#BlogModule",
        data: {
            backgroundColor: SystemColors.BG_BLOG
        }
    },
    {
        path: "news",
        loadChildren: "es6-promise!./modules/news/news.module#NewsModule",
        data: {
            backgroundColor: SystemColors.BG_NEWS
        }
    },
    {
        path: "dashboard",
        loadChildren: "es6-promise!./modules/dashboard/dashboard.module#DashboardModule",
        data: {
            backgroundColor: SystemColors.BG_DASHBOARD
        }
    },
    {
        path: '**',
        component: HomeContainer
    }
];