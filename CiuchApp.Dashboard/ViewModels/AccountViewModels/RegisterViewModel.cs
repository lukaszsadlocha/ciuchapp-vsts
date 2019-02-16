using System.ComponentModel.DataAnnotations;

namespace CiuchApp.Dashboard.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        //[EmailAddress]
        [Display(Name = "Użytkownik")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdz hasło")]
        [Compare("Password", ErrorMessage = "Hasła do siebie nie pasują.")]
        public string ConfirmPassword { get; set; }
    }
}
