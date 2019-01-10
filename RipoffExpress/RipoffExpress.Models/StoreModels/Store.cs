using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.Models;

namespace RipoffExpress.Models
{
    public class StoreViewModel
    {
        public StoreViewModel()
        {

        }
        public StoreViewModel(int? Id, Account account, string Name, string Description, string MediaUrl, List<Product> products, List<Category> categories)
        {
            this.Id = Id;
            this.Account = account;
            this.Name = Name;
            this.Description = Description;
            this.MediaUrl = MediaUrl;
            this.Products = products;
            this.Categories = categories;
        }
        public int? Id { get; private set; }
        public Account Account { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string MediaUrl { get; private set; }
        public List<Product> Products = new List<Product>();
        public List<Category> Categories = new List<Category>();
    }
}
