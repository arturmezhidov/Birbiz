using System.ComponentModel.DataAnnotations;

namespace Birbiz.WebServices.Auth.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Login { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Длина пароля должна быть не менее {2} символов и не более {1}", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}