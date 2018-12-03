using System.ComponentModel.DataAnnotations;

namespace CiuchApp.Dashboard.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
