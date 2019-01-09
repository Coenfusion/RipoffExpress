using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RipoffExpress.Models
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

        public AccountDetails(int Id, string Username, string Email, string Password, List<ShippingAddress> AddressBook)
        {
            this.Id = Id;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
            this.AddressBook = AddressBook;
        }

        public int Id { get; private set; }
        [Required]
        [EmailAddress]
        public string Email { get; private set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; private set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string Password { get; private set; }

        [Required]
        [Display(Name = "New Password")]
        [DataType(DataType.Password)]
        public string NewPassword { get; private set; }

        public List<ShippingAddress> AddressBook { get; private set; }   
    }
}
