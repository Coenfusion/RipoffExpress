using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.Models;

namespace RipoffExpress.DAL
{
    public interface IStoreContext
    {
        StoreViewModel StoreDetails(int? userId);
    }
}
