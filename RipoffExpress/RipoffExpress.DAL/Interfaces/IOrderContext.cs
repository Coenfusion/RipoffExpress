using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.Models;

namespace RipoffExpress.DAL
{
    public interface IOrderContext
    {
        List<Order> OrderOverview(int? id);
        Order OrderByStatus(int? id, OrderStatus status);
        void RemoveProductFromOrder(int? productId, int? orderId);
    }
}
