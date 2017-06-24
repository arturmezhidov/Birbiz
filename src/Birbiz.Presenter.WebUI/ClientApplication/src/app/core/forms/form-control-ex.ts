import { FormControl } from '@angular/forms';


export class FormControlEx extends FormControl {

    public get errorKeys(): string[] {
        return Object.keys(this.errors || {});
    }

    public get hasErrors(): boolean {
        return this.errorKeys.length > 0;
    }

    public get firstError(): string {
        if (this.hasErrors) {
            return this.getError(this.errorKeys[0]);
        }
        return null;
    }

    public get dirtyInvalid(): boolean {
        return this.dirty && this.invalid;
    }

    public get dirtyValid(): boolean {
        return this.dirty && this.valid;
    }
}