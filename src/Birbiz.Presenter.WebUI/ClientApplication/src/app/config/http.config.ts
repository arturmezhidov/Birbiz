export class HttpConfig {
    public static BASE_URL: string = "http://localhost:5123/";
    public static LOGIN_URL: string = HttpConfig.BASE_URL + "Account/Login";
    public static REGISTER_URL: string = HttpConfig.BASE_URL + "Account/Register";
}