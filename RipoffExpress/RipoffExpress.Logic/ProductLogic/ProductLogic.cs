using System.Collections.Generic;
using RipoffExpress.DAL;
using RipoffExpress.Models;
using RipoffExpress.Models.ProductModels;
using RipoffExpress.Repository;

namespace RipoffExpress.Logic
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
