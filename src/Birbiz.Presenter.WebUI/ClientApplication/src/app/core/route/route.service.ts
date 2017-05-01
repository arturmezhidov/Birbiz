import { Injectable } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { Observable, BehaviorSubject } from 'rxjs';

@Injectable()
export class RouteService {

    private router: Router;

    constructor(router: Router) {
        this.router = router;
    }

    public getCurrentRouteData(): any {
        let data: any = {};
        let activatedRoute: ActivatedRoute = this.router.routerState.root.firstChild;
        if (activatedRoute && activatedRoute.data instanceof BehaviorSubject) {
            let value: any = (<BehaviorSubject<any>>(activatedRoute.data)).value;
            if (value) {
                data = value;
            }
        }
        return data;
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