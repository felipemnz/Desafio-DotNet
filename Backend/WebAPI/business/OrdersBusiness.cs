using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    public class OrdersBusiness
    {
        public List<Orders> GetAllOrders(string idclient)
        {
            return new dbConn.OrdersConn().GetAll(idclient);
        }
    }
}
