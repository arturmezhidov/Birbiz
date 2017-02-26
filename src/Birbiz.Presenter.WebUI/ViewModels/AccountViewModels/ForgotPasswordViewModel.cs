using System.ComponentModel.DataAnnotations;

namespace Birbiz.Presenter.WebUI.ViewModels.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}