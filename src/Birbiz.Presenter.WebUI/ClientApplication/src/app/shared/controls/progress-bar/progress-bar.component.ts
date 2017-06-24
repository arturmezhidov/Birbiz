import { Component, Input } from '@angular/core';

@Component({
    selector: 'progress-bar',
    templateUrl: './progress-bar.component.html'
})
export class ProgressBarComponent {

    @Input()
    public value: number;

    @Input()
    public maxValue: number;

    @Input()
    public isStriped: boolean;

    @Input()
    public isAnimated: boolean;

    @Input()
    public status: string;

    public get percent(): number {
        let percentValue: number = this.calculatePercent(this.value, this.maxValue);
        return percentValue;
    }

    private calculatePercent(value: number, maxValue: number): number {
        if (!this.value || this.value <= 0) {
            return 0;
        }
        if (!this.maxValue || this.maxValue <= 0) {
            return 1;
        }
        if (this.maxValue === this.value) {
            return 1;
        }
        let percentValue: number = (this.value / this.maxValue);
        return percentValue;
    }
}