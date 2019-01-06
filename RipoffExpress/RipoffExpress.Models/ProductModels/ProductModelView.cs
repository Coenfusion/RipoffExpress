using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Models
{
    public class ProductModelView
    {
        public ProductModelView(string _MediaUrl, string _Name, decimal _Price, int Id)
        {
            this.MediaUrl = _MediaUrl;
            this.Name = _Name;
            this.Price = _Price;
            this.Id = Id;
        }
        public int Id { get; private set; }
        public string MediaUrl { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
