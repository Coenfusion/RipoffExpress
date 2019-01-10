using RipoffExpress.DAL;
using RipoffExpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Repository
{
    public class StoreRepository
    {
        private IStoreContext context;
        public StoreRepository(ContextType type)
        {
            switch (type)
            {
                case ContextType.MSSQLContext: context = new StoreContext(); break;
                case ContextType.MemoryContext: context = new StoreContext(); break;
            }
        }

        public StoreViewModel StoreDetails(int? userId) => context.StoreDetails(userId);
    }
}
