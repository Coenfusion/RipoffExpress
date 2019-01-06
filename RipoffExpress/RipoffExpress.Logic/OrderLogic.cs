using RipoffExpress.DAL;
using RipoffExpress.Models;
using RipoffExpress.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Logic
{
    public class OrderLogic
    {
        OrderRepository repo = new OrderRepository(ContextType.MSSQLContext);
        public List<Order> OrderOverview(int? Id) => repo.OrderOverview(Id);

        public void RemoveProductFromOrder(int? productId, int? orderId) => repo.RemoveProductFromOrder(productId, orderId);

        public Order OrderByStatus(int? Id, OrderStatus status)
        {
            if (repo.OrderByStatus(Id, status) == null)
            {
                throw new Exception("You currently have 0 products in your shopping cart.");
            }
            return repo.OrderByStatus(Id, status);
        }
    }
}
