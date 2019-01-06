using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Models
{
    public enum OrderStatus
    {
        AwaitingPayment = 0,
        AwaitingShipment = 1,
        Delivered = 2,
        ShoppingCart = 3,
        Wishlist = 4,
    }
}
