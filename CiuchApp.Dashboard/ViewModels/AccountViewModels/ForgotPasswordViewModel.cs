using System.ComponentModel.DataAnnotations;

namespace CiuchApp.Dashboard.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
