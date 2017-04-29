import { Component, Input } from '@angular/core';

@Component({
    selector: 'appbar-dropdown',
    templateUrl: './appbar-dropdown.component.html'
})
export class AppbarDropdownComponent {
    @Input() text: string;
    @Input() icon: string;
}