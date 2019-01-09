using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Models
{
    public class Product
    {
        public Product()
        {
        }

        public Product(int Id, string Name, string Description, decimal Price, string MediaUrl, Category category, int Store_Id)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.MediaUrl = MediaUrl;
            this.Category = category;
            this.Store_Id = Store_Id;
        }

        public int Id { get; private set; }
        public Category Category { get; private set; }
        public int Store_Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string MediaUrl { get; private set; }
    }
}
