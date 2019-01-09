using RipoffExpress.DAL;
using RipoffExpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Repository
{
    public class OrderRepository
    {
        private IOrderContext context;
        public OrderRepository(ContextType type)
        {
            switch (type)
            {
                case ContextType.MSSQLContext: context = new OrderContext(); break;
                case ContextType.MemoryContext: context = new OrderContext(); break;
            }
        }

        public void RemoveProductFromOrder(int? productId, int? orderId) => context.RemoveProductFromOrder(productId, orderId);

        public List<Order> OrderOverview(int? id) => context.OrderOverview(id);

        public Order OrderByStatus(int? id, OrderStatus status) => context.OrderByStatus(id, status);

        public Order OrderById(int? orderId) => context.OrderById(orderId);

        public void OrderFinalization(int? orderId) => context.OrderFinalization(orderId);
    }
}
