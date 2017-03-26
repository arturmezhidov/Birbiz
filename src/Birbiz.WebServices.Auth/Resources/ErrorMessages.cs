namespace Birbiz.WebServices.Auth.Resources
{
    public static class ErrorMessages
    {
        public const string LoginRequired = "Пожалуйста, введите логин.";
        public const string DuplicateUserName = "Пользователь с таким именем уже существует.";
        public const string PasswordRequired = "Пожалуйста, введите пароль.";
        public const string PasswordMinLength = "Длина пароля должна быть не менее {1} символов.";
        public const string PasswordMaxLength = "Длина пароля должна быть не более {1} символов.";
        public const string PasswordUnequal = "Пароли не совпадают.";
        public const string PasswordRequiresDigit = "Пароль должен содержать хоть одну цифру.";
        public const string PasswordRequiresLower = "Пароль должен содержать хоть одну маленькую букву.";
        public const string PasswordRequiresUpper = "Пароль должен содержать хоть одну большую букву.";
        public const string PasswordRequiresNonAlphanumeric = "Пароль должен содержать хоть одну небуквенный символ.";
        public const string InvalidLoginOrPassword = "Неверный логин или пароль.";
        public const string CannotSignIn = "Данный пользователь не имеет доступа.";
        public const string TwoFactor = "Данный пользователь не имеет доступа.";
        public const string Lockout = "Данный пользователь заблокирован.";
        public const string PasswordGrantType = "Ошибка входа в систему.";
    }
}