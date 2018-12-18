using System.ComponentModel.DataAnnotations;

namespace RipoffExpress.Models
{
     public class ShippingAddress
     {
        public ShippingAddress()
        {

        }
        public ShippingAddress(string Address, string PostalCode, string City, string Province, string Country, string PhoneNumber)
        {
            this.Address = Address;
            this.PostalCode = PostalCode;
            this.City = City;
            this.Province = Province;
            this.Country = Country;
            this.PhoneNumber = PhoneNumber;
        }
        public ShippingAddress(int? Id, string Address, string PostalCode, string City, string Province, string Country, string PhoneNumber, bool Default)
        {
            this.Id = Id;
            this.Address = Address;
            this.PostalCode = PostalCode;
            this.City = City;
            this.Province = Province;
            this.Country = Country;
            this.PhoneNumber = PhoneNumber;
            this.Default = Default;
        }
        public int? Id { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Province")]
        public string Province { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public bool Default { get; set; }
     }
}
