using RipoffExpress.DAL;
using RipoffExpress.DAL.Interfaces;
using RipoffExpress.DAL.MSSQLContext;
using RipoffExpress.Models;
using RipoffExpress.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Repository.Product
{
    public class ProductRepository
    {
        private IProductContext Context;
        public ProductRepository(ContextType type)
        {
            switch (type)
            {
                case ContextType.MSSQLContext: Context = new ProductContext(); break;
                case ContextType.MemoryContext: Context = new ProductContext(); break;
            }
        }

        public IEnumerable<ProductModelView> MostRecentProducts() => Context.MostRecentProducts();
        public IEnumerable<Category> LoadCategories() => Context.LoadCategories();


    }
}
