using AspNet.Security.OpenIdConnect.Primitives;

namespace Birbiz.WebServices.Auth.Configuration
{
    public static class AuthOptions
    {
        public const int PasswordMinLength = 6;
        public const int PasswordMaxLength = 100;
        public const bool PasswordRequireLowercase = true;
        public const bool PasswordRequireUppercase = true;
        public const bool PasswordRequireDigit = true;
        public const bool PasswordRequireNonAlphanumeric = false;
        public const string TokenEndpoint = "/token";
        public const string UserNameClaimType = OpenIdConnectConstants.Claims.Name;
        public const string UserIdClaimType = OpenIdConnectConstants.Claims.Subject;
        public const string RoleClaimType = OpenIdConnectConstants.Claims.Role;
    }
}