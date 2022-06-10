using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data.DataEntities
{
    public class Category : BaseEntity
    {
        public string CategoryDescription { get;  set; }
        public string CategoryName { get; set; }
    }
}
