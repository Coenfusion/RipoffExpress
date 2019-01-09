using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Models
{
    public class Category
    {
        public Category(int? Id)
        {
            this.Id = Id;
        }
        public Category(int? Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public int? Id { get; private set; }
        public string Name { get; private set; }
    }
}
