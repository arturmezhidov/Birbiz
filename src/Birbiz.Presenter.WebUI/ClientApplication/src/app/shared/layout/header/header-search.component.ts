import { Component, Input } from '@angular/core';

@Component({
    selector: 'header-search',
    templateUrl: './header-search.component.html'
})
export class HeaderSearchComponent {

    public isActive: boolean;

    public onFocusin(): void {
        this.isActive = true;
    }

    public onFocusout(): void {
        this.isActive = false;
    }
}