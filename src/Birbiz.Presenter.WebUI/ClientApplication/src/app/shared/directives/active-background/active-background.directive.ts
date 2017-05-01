import { Directive, ElementRef, Input, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs/Subscription';
import { RouteService } from '../../../core/route';
import { SystemColors } from '../../../config/system-colors';

@Directive({
    selector: '[active-background]'
})
export class ActiveBackgroundDirective implements OnInit, OnDestroy {

    private elementRef: ElementRef;
    private routeService: RouteService;
    private subscription: Subscription

    @Input("active-background")
    public defaultValue: string;

    constructor(elementRef: ElementRef, routeService: RouteService) {
        this.elementRef = elementRef;
        this.routeService = routeService;
    }

    ngOnInit(): void {
        this.subscription = this.routeService.getRouteData().subscribe((data: any) => {
            let backgroundColor: string = data && data.uiSettings && data.uiSettings.backgroundColor;
            this.elementRef.nativeElement.style.backgroundColor = backgroundColor || this.defaultValue || SystemColors.BG_DEFAULT;
        });
    }

    ngOnDestroy(): void {
        this.subscription.unsubscribe();
    }
}