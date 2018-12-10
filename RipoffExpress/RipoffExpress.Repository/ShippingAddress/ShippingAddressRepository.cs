using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
