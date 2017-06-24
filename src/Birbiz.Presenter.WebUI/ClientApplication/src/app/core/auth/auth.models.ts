export class Login {

    public login: string;
    public password: string;
    public rememberMe: boolean;

    constructor(
            login?: string,
            password?: string,
            rememberMe?: boolean) {
        this.login = login;
        this.password = password;
        this.rememberMe = rememberMe;
    }
}

export class Register {

    public login: string;
    public password: string;
    public confirmPassword: string;

    constructor(
            login?: string,
            password?: string,
            confirmPassword?: string) {
        this.login = login;
        this.password = password;
        this.confirmPassword = confirmPassword;
    }
}

export class Token {

    accessToken: string;
    refreshToken: string;
    tokenType: string;
    expiresIn: number;

    constructor(
            accessToken?: string,
            refreshToken?: string,
            tokenType?: string,
            expiresIn?: number) {
        this.accessToken = accessToken;
        this.refreshToken = refreshToken;
        this.tokenType = tokenType;
        this.expiresIn = expiresIn;
    }
}