import { ErrorResponse } from '../http';

export class RegisterErrors {

    public loginError: string;
    public passwordError: string;
    public confirmPasswordError: string;

    constructor() {
        this.loginError = '';
        this.passwordError = '';
        this.confirmPasswordError = '';
    }

    public static parse(response: ErrorResponse): RegisterErrors {
        let errors: RegisterErrors = new RegisterErrors();
        if (response && response.errors) {

            // login errors
            errors.loginError = response.errors.login
                || response.errors.duplicateUserName
                || '';

            // password errors
            errors.passwordError = response.errors.password
                || response.errors.passwordRequiresDigit
                || response.errors.passwordRequiresLower
                || response.errors.passwordRequiresUpper
                || response.errors.passwordRequiresNonAlphanumeric
                || '';

            // password confirm errors
            errors.confirmPasswordError = response.errors.confirmPassword
                || '';
        }
        return errors;
    }
}