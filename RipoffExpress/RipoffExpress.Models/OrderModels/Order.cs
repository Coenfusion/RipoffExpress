using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.Models;

namespace RipoffExpress.Models
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int Id, OrderStatus status, string OrderTime, List<ProductModelView> orderItems)
        {
            this.Id = Id;
            this.OrderStatus = status;
            this.OrderTime = OrderTime;
            this.OrderItems = orderItems;
        }

        public int Id { get; private set; }
        public OrderStatus OrderStatus { get; private set; }
        public string OrderTime { get; private set; }

        public List<ProductModelView> OrderItems = new List<ProductModelView>();

    }
}
