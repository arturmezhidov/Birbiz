import { Component, Input } from '@angular/core';

@Component({
    selector: 'appbar-logo',
    templateUrl: './appbar-logo.component.html'
})
export class AppbarLogoComponent {
    @Input() link: Array<string>;
    @Input() image: string;
}