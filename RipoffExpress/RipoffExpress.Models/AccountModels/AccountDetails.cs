using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RipoffExpress.Models.AccountModels
{
    public class AccountDetails
    {
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

        public ShippingAddress ShippingAddress { get; set; }   
    }
}
