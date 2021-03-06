﻿export class HttpConfig {
    public static BASE_URL: string = "/";
    public static TOKEN_ENDPOINT: string = HttpConfig.BASE_URL + "token";
    public static REGISTER_URL: string = HttpConfig.BASE_URL + "Account/Register";
    public static USERINFO_URL: string = HttpConfig.BASE_URL + "User/UserInfo";
}