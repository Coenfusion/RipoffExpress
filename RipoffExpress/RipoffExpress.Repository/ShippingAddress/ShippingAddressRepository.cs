using System.Collections.Generic;
using RipoffExpress.Models;
using RipoffExpress.DAL;

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

        public void SaveChanges(ShippingAddress shippingAddress, int? UserId, int? AddressId) => context.SaveChanges(shippingAddress,UserId, AddressId);

        public void DeleteAddress(int? AddressId) => context.DeleteAddress(AddressId);
        public void SetAsDefault(int? AddressId) => context.SetAsDefault(AddressId);
    }
}
