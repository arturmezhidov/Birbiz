import { Component, Input } from '@angular/core';

@Component({
    selector: 'navbar-item',
    templateUrl: './navbar-item.component.html'
})
export class NavbarItemComponent {
    @Input() link: Array<string>;
    @Input() text: string;
    @Input() icon: string;
    @Input() color: string;
    @Input() background: string;
    @Input() isLinkExact: boolean;
}