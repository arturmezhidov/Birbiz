import { FormGroup, FormControl, ValidatorFn } from '@angular/forms';

export class CustomValidators {

    public static equal(keys: Array<string>): ValidatorFn {
        return (group: FormGroup): { [key: string]: any } => {
            if (keys && keys.length) {
                let value = group.controls[keys[0]].value;
                for (let i = 1; i < keys.length; i++) {
                    let nextValue = group.controls[keys[i]].value;
                    if (value !== nextValue) {
                        return {
                            equal: true
                        };
                    }
                }
            }
        }
    }

    public static digitRequired(control: FormControl): { [key: string]: any } {
        if (control.value) {
            var digitRegx = /[0-9]+/;
            if (!digitRegx.test(control.value)) {
                return {
                    digitRequired: true
                };
            }
        }
    }

    public static lowerRequired(control: FormControl): { [key: string]: any } {
        if (control.value) {
            var lowerRegx = /[a-zа-яё]+/;
            if (!lowerRegx.test(control.value)) {
                return {
                    lowerRequired: true
                };
            }
        }
    }

    public static upperRequired(control: FormControl): { [key: string]: any } {
        if (control.value) {
            var upperRegx = /[A-ZА-ЯЁ]+/;
            if (!upperRegx.test(control.value)) {
                return {
                    upperRequired: true
                };
            }
        }
    }

    public static nonAlphanumericRequired(control: FormControl): { [key: string]: any } {
        if (control.value) {
            var nonAlphanumericRegx = /[^0-9A-ZА-ЯЁa-zа-яё]+/;
            if (!nonAlphanumericRegx.test(control.value)) {
                return {
                    nonAlphanumericRequired: true
                };
            }
        }
    }
}