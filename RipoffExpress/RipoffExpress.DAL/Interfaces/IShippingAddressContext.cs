using System.Collections.Generic;
using RipoffExpress.Models;

namespace RipoffExpress.DAL
{
    public interface IShippingAddressContext
    {
        //Create, Edit, Delete
        void CreateNewAddress(ShippingAddress shippingAddress, int? Id);
        void SaveChanges(ShippingAddress shippingAddress, int? UserId, int? AddressId);
        void DeleteAddress(int? AddressId);
        void SetAsDefault(int? AddressId);
        //Retrieve
        ShippingAddress AddressDetails(int? AddressId);
        List<ShippingAddress> GetAddresses(int? Id);
        //Logic
        bool CheckForDuplicate(ShippingAddress shippingAddress);
    }
}
