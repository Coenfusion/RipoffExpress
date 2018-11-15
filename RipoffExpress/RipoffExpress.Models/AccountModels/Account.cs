using System.ComponentModel.DataAnnotations;

namespace RipoffExpress.Models.AccountModels
{
    public class Account
    {
        public Account(string _email, string _password)
        {
            this.Email = _email;
            this.Password = _password;
        }
        public Account(string _email, string _username, string _password, string _rpassword)
        {
            this.Email = _email;
            this.Username = _username;
            this.Password = _password;
            this.RepeatPassword = _rpassword;
        }
        public Account(int _id, string _email, string _username, ShippingAddress _shippingAddress)
        {
            this.Id = _id;
            this.Email = _email;
            this.Username = _username;
            this.ShippingAddress = _shippingAddress;
        }
        public int Id { get; private set; }
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

        public ShippingAddress ShippingAddress { get; set; }
    }
}
