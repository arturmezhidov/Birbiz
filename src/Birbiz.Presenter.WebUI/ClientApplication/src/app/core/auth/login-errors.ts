import { ErrorResponse } from '../http';

export class LoginErrors {

    public loginError: string;
    public passwordError: string;

    constructor() {
        this.loginError = '';
        this.passwordError = '';
    }

    public static parse(response: ErrorResponse): LoginErrors {
        let errors: LoginErrors = new LoginErrors();
        if (response) {
            if (response.errors) {

                // login errors
                errors.loginError = response.errors.login
                    || response.errors.signinError
                    || '';

                // login password
                errors.passwordError = response.errors.password
                    || '';
            } else if ((<any>response).error_description) {
                errors.loginError = (<any>response).error_description;
            }
        }
        return errors;
    }
}