using System.ComponentModel.DataAnnotations;
using Birbiz.WebServices.Auth.Configuration;
using Birbiz.WebServices.Auth.Resources;

namespace Birbiz.WebServices.Auth.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = ErrorMessages.LoginRequired)]
        public string Login { get; set; }

        [Required(ErrorMessage = ErrorMessages.PasswordRequired)]
        [MinLength(AuthOptions.PasswordMinLength, ErrorMessage = ErrorMessages.PasswordMinLength)]
        [MaxLength(AuthOptions.PasswordMaxLength, ErrorMessage = ErrorMessages.PasswordMaxLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = ErrorMessages.PasswordUnequal)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}