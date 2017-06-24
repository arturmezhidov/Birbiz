export class AccountResources {
    public static loginRequired: string = 'Пожалуйста, введите логин.';
    public static passwordRequired: string = 'Пожалуйста, введите пароль.';
    public static passwordMinLength: string = 'Длина пароля должна быть не менее 6 символов.';
    public static passwordMaxLength: string = 'Длина пароля должна быть не более 100 символов.';
    public static passwordConfirmRequired: string = 'Повтор пароля обязателен.';
    public static passwordUnequal: string = 'Пароли не совпадают.';
    public static passwordRequiresDigit: string = 'Пароль должен содержать хоть одну цифру.';
    public static passwordRequiresLower: string = 'Пароль должен содержать хоть одну маленькую букву.';
    public static passwordRequiresUpper: string = 'Пароль должен содержать хоть одну большую букву.';
    public static passwordRequiresNonAlphanumeric: string = 'Пароль должен содержать хоть один небуквенный символ.';
    public static emailRequired: string = 'Пожалуйста, введите электронный адрес.';
    public static emailInvalid: string = 'Неверный электронный адрес.';
}