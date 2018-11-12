using System.ComponentModel.DataAnnotations;

namespace RipoffExpress.Models.AccountModels
{
    public class AccountRegister
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Repeat Password")]
        public string RepeatPassword { get; set; }
    }
}
