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
        public int Id { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public List<ProductModelView> OrderItems = new List<ProductModelView>();
    }
}
