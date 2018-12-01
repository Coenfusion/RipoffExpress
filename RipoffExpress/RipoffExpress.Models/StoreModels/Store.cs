using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.Models.AccountModels;

namespace RipoffExpress.Models
{
    public class Store
    {
        public Account Account { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MediaUrl { get; set; }
    }
}
