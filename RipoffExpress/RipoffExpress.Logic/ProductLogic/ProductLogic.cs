using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.DAL;
using RipoffExpress.Models;
using RipoffExpress.Models.ProductModels;
using RipoffExpress.Repository.Product;

namespace RipoffExpress.Logic.ProductLogic
{
    public class ProductLogic
    {
        ProductRepository repo = new ProductRepository(ContextType.MSSQLContext);
        public IEnumerable<ProductModelView> MostRecentProducts()
        {
            return repo.MostRecentProducts();
        }
        public IEnumerable<Category> LoadCategories()
        {
            return repo.LoadCategories();
        }
    }
}
