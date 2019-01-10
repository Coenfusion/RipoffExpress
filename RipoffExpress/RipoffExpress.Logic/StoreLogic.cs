using RipoffExpress.DAL;
using RipoffExpress.Models;
using RipoffExpress.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Logic
{
    public class StoreLogic
    {
        StoreRepository repo = new StoreRepository(ContextType.MSSQLContext);
        public StoreViewModel StoreDetails(int? userId) => repo.StoreDetails(userId);
    }
}
