using System;
using System.Collections.Generic;
using System.Linq;
using RipoffExpress.Models;
using RipoffExpress.Repository;
using RipoffExpress.DAL;

namespace RipoffExpress.Logic
{
    public class ShippingAddressLogic
    {
        ShippingAddressRepository repo = new ShippingAddressRepository(ContextType.MSSQLContext);
        //Retrieve info
        public List<ShippingAddress> GetAddresses(int? Id) => repo.GetAddresses(Id);
        public ShippingAddress AddressDetails(int? AddressId) => repo.AddressDetails(AddressId);
        //Logic Check
        public bool CheckEmptyFields(object _object)
        {
            return _object.GetType().GetProperties()
               .Where(x => x.PropertyType == typeof(string))
               .Select(x => (string)x.GetValue(_object))
               .Any(value => string.IsNullOrEmpty(value));
        }
        //Create, Edit, Delete
        public void CreateNewAddress(ShippingAddress shippingAddress, int? Id)
        {
            if (CheckEmptyFields(shippingAddress))
            {
                throw new Exception("Some of the fields are still empty.");
            }
            if (repo.CheckForDuplicate(shippingAddress))
            {
                throw new Exception("You have already saved this address");
            }
            repo.CreateNewAddress(shippingAddress, Id);
        }
        public void SaveChanges(ShippingAddress shippingAddress)
        {
            if (CheckEmptyFields(shippingAddress))
            {
                throw new Exception("Some of the fields are still empty.");
            }
            if (repo.CheckForDuplicate(shippingAddress))
            {
                throw new Exception("You have already saved this address");
            }
            repo.SaveChanges(shippingAddress);
        }
        public void DeleteAddress(int? Id) => repo.DeleteAddress(Id);

        public void RemoveDefault(int? UserId) => repo.RemoveDefault(UserId);

        public void SetAsDefault(int? Id) => repo.SetAsDefault(Id);
    }
}
