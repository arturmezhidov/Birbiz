import { FormGroup, FormControl, ValidatorFn } from '@angular/forms';

export class CustomValidators {

    public static required(message: string): ValidatorFn {
        return (control: FormControl): { [key: string]: any } => {
            if (!control.value) {
                return {
                    required: message || true
                };
            }
            return null;
        }
    }

    public static minLength(message: string, length: number): ValidatorFn {
        return (control: FormControl): { [key: string]: any } => {
            if (!control.value || (<string>control.value).length < length) {
                return {
                    minLength: message || true
                };
            }
            return null;
        }
    }

    public static maxLength(message: string, length: number): ValidatorFn {
        return (control: FormControl): { [key: string]: any } => {
            if (!control.value || (<string>control.value).length > length) {
                return {
                    maxLength: message || true
                };
            }
            return null;
        }
    }

    public static email(message: string): ValidatorFn {
        return (control: FormControl): { [key: string]: any } => {
            if (control.value) {
                let MIN_LENGTH = 5;
                let EMAIL_REGEXP = /^[a-z0-9!#$%&'*+\/=?^_`{|}~.-]+@[a-z0-9]([a-z0-9-]*[a-z0-9])?(\.[a-z0-9]([a-z0-9-]*[a-z0-9])?)*$/i;
                if (control.value.length < MIN_LENGTH || !EMAIL_REGEXP.test(control.value)) {
                    return {
                        email: message || true
                    };
                }
            }
            return null;
        }
    }

    public static digitRequired(message: string): ValidatorFn {
        return (control: FormControl): { [key: string]: any } => {
            if (control.value) {
                var digitRegx = /[0-9]+/;
                if (!digitRegx.test(control.value)) {
                    return {
                        digitRequired: message || true
                    };
                }
            }
            return null;
        }
    }

    public static lowerRequired(message: string): ValidatorFn {
        return (control: FormControl): { [key: string]: any } => {
            if (control.value) {
                var lowerRegx = /[a-zа-яё]+/;
                if (!lowerRegx.test(control.value)) {
                    return {
                        lowerRequired: message || true
                    };
                }
            }
            return null;
        }
    }

    public static upperRequired(message: string): ValidatorFn {
        return (control: FormControl): { [key: string]: any } => {
            if (control.value) {
                var upperRegx = /[A-ZА-ЯЁ]+/;
                if (!upperRegx.test(control.value)) {
                    return {
                        upperRequired: message || true
                    };
                }
            }
            return null;
        }
    }

    public static nonAlphanumericRequired(message: string): ValidatorFn {
        return (control: FormControl): { [key: string]: any } => {
            if (control.value) {
                var nonAlphanumericRegx = /[^0-9A-ZА-ЯЁa-zа-яё]+/;
                if (!nonAlphanumericRegx.test(control.value)) {
                    return {
                        nonAlphanumericRequired: message || true
                    };
                }
            }
            return null;
        }
    }
 
    public static equal(message: string, keys: Array<string>): ValidatorFn {
        return (control: FormControl): { [key: string]: any } => {
            if (keys && keys.length && control.parent) {
                let value = control.value;
                let group = control.parent;
                for (let i = 0; i < keys.length; i++) {
                    let nextValue = group.controls[keys[i]].value;
                    if (value !== nextValue) {
                        return {
                            equal: message || true
                        };
                    }
                }
            }
            return null;
        }
    }
}