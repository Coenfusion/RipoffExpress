using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Models
{
    public enum OrderStatus
    {
        AwaitingPayment,
        AwaitingShipment,
        Delivered,
        ShoppingCart,
        Wishlist,
    }
}
