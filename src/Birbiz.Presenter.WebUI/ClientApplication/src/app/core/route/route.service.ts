import { Injectable } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class RouteService {

    private router: Router;

    constructor(router: Router) {
        this.router = router;
    }

    public getRouteData(): Observable<any> {
        return this.router.events
            .filter(event => event instanceof NavigationEnd)
            .map(_ => this.router.routerState.root)
            .map(route => {
                while (route.firstChild) route = route.firstChild;;
                return route;
            })
            .flatMap(route => route.data);
    }
}