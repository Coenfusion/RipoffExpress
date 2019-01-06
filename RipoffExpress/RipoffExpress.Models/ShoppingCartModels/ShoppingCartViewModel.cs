using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Models
{
    public class ShoppingCartViewModel
    {
        public AccountDetails account { get; set; }
        public Order order { get; set; }
    }
}
