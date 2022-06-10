using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data.DataEntities
{
    public class Order : BaseEntity
    {
        public Customer Customer { get;  set; }
        public List<Product> OrderProducts { get;  set; }
        public OrderState OrderState { get;  set; }
    }
}
