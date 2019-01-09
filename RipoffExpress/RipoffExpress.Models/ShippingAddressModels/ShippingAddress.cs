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
        public int? Id { get; private set; }
        [Display(Name = "Address")]
        public string Address { get; private set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; private set; }

        [Display(Name = "City")]
        public string City { get; private set; }

        [Display(Name = "Province")]
        public string Province { get; private set; }

        [Display(Name = "Country")]
        public string Country { get; private set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; private set; }
        public bool Default { get; private set; }
     }
}
