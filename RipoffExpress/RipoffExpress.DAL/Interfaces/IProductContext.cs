using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.Models;
using RipoffExpress.Models.ProductModels;

namespace RipoffExpress.DAL.Interfaces
{
    public interface IProductContext
    {
        IEnumerable<ProductModelView> MostRecentProducts();
        IEnumerable<Category> LoadCategories();
    }
}
