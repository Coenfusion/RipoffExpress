using System;
using System.Collections.Generic;
using RipoffExpress.DAL;
using RipoffExpress.Models;
using RipoffExpress.Repository;

namespace RipoffExpress.Logic
{
    public class ProductLogic
    {
        ProductRepository repo = new ProductRepository(ContextType.MSSQLContext);
        public IEnumerable<ProductModelView> MostRecentProducts() => repo.MostRecentProducts();
        
        public IEnumerable<Category> LoadCategories() => repo.LoadCategories();
        
        public IEnumerable<ProductModelView> ProductByCategory(int? Id) => repo.ProductByCategory(Id);
        
    }
}