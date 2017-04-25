export class Login {
    public login: string;
    public password: string;
    public rememberMe: boolean;
}

export class Register {
    public login: string;
    public password: string;
    public confirmPassword: string;
}

export class Token {
    accessToken: string;
    refreshToken: string;
    tokenType: string;
    expiresIn: number;
}