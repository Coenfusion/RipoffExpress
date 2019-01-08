using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.Models;

namespace RipoffExpress.DAL.Interfaces
{
    public interface IProductContext
    {
        IEnumerable<ProductModelView> MostRecentProducts();
        IEnumerable<Category> LoadCategories();
        IEnumerable<ProductModelView> ProductByCategory(int? Id);
        Product ProductById(int? Id);
        IEnumerable<ProductModelView> ProductByCriteria(string criteria);
    }
}
