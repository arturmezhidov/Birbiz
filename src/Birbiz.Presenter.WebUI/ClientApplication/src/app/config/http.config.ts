export class HttpConfig {
    public static BASE_URL: string = "http://localhost:5123/";
    public static TOKEN_ENDPOINT: string = HttpConfig.BASE_URL + "token";
    public static REGISTER_URL: string = HttpConfig.BASE_URL + "Account/Register";
}