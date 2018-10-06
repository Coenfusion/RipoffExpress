using System.ComponentModel.DataAnnotations;

namespace RipoffExpress.Models.Models
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
        [Display(Name = "Repeat Password")]
        public string RepeatPassword { get; set; }
    }
}
