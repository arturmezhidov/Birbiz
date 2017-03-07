using System.ComponentModel.DataAnnotations;

namespace Birbiz.WebServices.Auth.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}