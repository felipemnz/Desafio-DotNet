using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class OrderDetails
    {
        public string Order_id { get; set; }
        public string Product_id { get; set; }
        public float Unit_prince { get; set; }
        public long Quantity { get; set; }
        public long Discount { get; set; }
    }
}
