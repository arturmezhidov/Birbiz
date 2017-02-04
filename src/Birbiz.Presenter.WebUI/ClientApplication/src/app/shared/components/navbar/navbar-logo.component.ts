import { Component, Input } from '@angular/core';

@Component({
    selector: 'navbar-logo',
    templateUrl: './navbar-logo.component.html'
})
export class NavbarLogoComponent {
    @Input() link: Array<string>;
    @Input() image: string;
    @Input() background: string;
}