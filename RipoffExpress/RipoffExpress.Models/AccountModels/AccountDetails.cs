using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RipoffExpress.Models.AccountModels
{
    public class AccountDetails
    {
        public AccountDetails()
        {

        }
        public AccountDetails(string Email, string Username)
        {
            this.Email = Email;
            this.Username = Username;
        }
        public int Id { get; set; }
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
        [Display(Name = "New Password")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        public ShippingAddress ShippingAddress { get; set; }   
    }
}
