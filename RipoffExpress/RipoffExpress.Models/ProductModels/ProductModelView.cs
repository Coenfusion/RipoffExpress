using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Models.ProductModels
{
    public class ProductModelView
    {
        public ProductModelView(string _MediaUrl, string _Name, decimal _Price)
        {
            this.MediaUrl = _MediaUrl;
            this.Name = _Name;
            this.Price = _Price;
        }
        public string MediaUrl { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
