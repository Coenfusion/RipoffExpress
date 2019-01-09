using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Models
{
    public class ShoppingCartViewModel
    {
        public AccountDetails Account { get; set; }
        public Order Order { get; set; }
    }
}
