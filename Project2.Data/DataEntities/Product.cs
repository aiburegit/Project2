using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data.DataEntities
{
    public class Product : BaseEntity
    {
        public string ProductName { get;  set; }
        public Category Category { get;  set; }
        public Unit Unit { get;  set; }
        public int ProductCount { get;  set; }
        public int PriceMultiplicate { get;  set; }
        public int ProductPrice { get;  set; }
        public string ProductDescription { get;  set; }
    }
}
