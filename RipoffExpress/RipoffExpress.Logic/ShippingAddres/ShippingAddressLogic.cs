using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.Models;
using RipoffExpress.Repository;
using RipoffExpress.DAL;

namespace RipoffExpress.Logic
{
    public class ShippingAddressLogic
    {
        ShippingAddressRepository repo = new ShippingAddressRepository(ContextType.MSSQLContext);
        public List<ShippingAddress> GetAddresses(int? Id) => repo.GetAddresses(Id);
    }
}
