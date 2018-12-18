using System.Collections.Generic;
using RipoffExpress.Models;
using RipoffExpress.DAL;
using System;

namespace RipoffExpress.Repository
{
    public class ShippingAddressRepository
    {
        private IShippingAddressContext context;
        public ShippingAddressRepository(ContextType type)
        {
            switch (type)
            {
                case ContextType.MSSQLContext: context = new ShippingAddressContext(); break;
                case ContextType.MemoryContext: context = new ShippingAddressContext(); break;
            }
        }
        public List<ShippingAddress> GetAddresses(int? Id) => context.GetAddresses(Id);

        public bool CheckForDuplicate(ShippingAddress shippingAddress) => context.CheckForDuplicate(shippingAddress);

        public void CreateNewAddress(ShippingAddress shippingAddress, int? Id) => context.CreateNewAddress(shippingAddress, Id);

        public ShippingAddress AddressDetails(int? AddressId) => context.AddressDetails(AddressId);

        public void SaveChanges(ShippingAddress shippingAddress) => context.SaveChanges(shippingAddress);

        public void DeleteAddress(int? Id) => context.DeleteAddress(Id);
        public void SetAsDefault(int? Id) => context.SetAsDefault(Id);

        public void RemoveDefault(int? UserId) => context.RemoveDefault(UserId);
    }
}
