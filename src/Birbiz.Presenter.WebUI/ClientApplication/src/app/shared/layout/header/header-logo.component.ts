import { Component, Input } from '@angular/core';

@Component({
    selector: 'header-logo',
    templateUrl: './header-logo.component.html'
})
export class HeaderLogoComponent {

    @Input()
    public link: Array<string>;

    @Input()
    public image: string;
}