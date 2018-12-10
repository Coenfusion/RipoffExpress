using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.Models;

namespace RipoffExpress.DAL
{
    public interface IShippingAddressContext
    {
        List<ShippingAddress> GetAddresses(int? Id);
    }
}
