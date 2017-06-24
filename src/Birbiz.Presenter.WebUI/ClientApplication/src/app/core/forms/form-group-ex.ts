import { FormGroup, AbstractControl, ValidatorFn, AsyncValidatorFn } from '@angular/forms';
import { FormControlEx } from './form-control-ex';

export class FormGroupEx extends FormGroup {

    public getModel<T>(): T {
        return <T>this.value;
    }

    public getControlValue(controlName: string): any {
        let control: FormControlEx = <FormControlEx>this.controls[controlName];
        if (control) {
            return control.value;
        }
        return null;
    }

    public extraErrors(errors: { [key: string]: string }): void {
        let keys: Array<string> = Object.keys(errors || {});
        if (keys.length) {
            for (var i = 0; i < keys.length; i++) {
                let controlName = keys[i];
                let message = errors[controlName];
                if (message && this.contains(controlName)) {
                    this.controls[controlName].setErrors({
                        extra: message
                    });
                }
            }
        }
    }
}