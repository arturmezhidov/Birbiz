﻿import { Component, Input } from '@angular/core';

@Component({
    selector: 'navbar-item',
    templateUrl: './navbar-item.template.html'
})
export class NavbarItemComponent {
    @Input() link: Array<string>;
    @Input() text: string;
}