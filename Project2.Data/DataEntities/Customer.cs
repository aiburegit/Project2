using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data.DataEntities
{
    public class Customer : BaseEntity
    {
        public string CustomerName { get;  set; }
        public string CustomerPhone { get;  set; }
        public Region CustomerRegion { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
    }
}
