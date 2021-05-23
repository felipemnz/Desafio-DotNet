using models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbConn
{
    public class OrdersConn: Conn
    {
        public List<Orders> GetAll(string idClient)
        {
            List<Orders> list = new List<Orders>();

            using (var con = new SqlConnection(ConnString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                var cmd = new SqlCommand("sp_getorder_by_idclient");
                cmd.Parameters.AddWithValue("@idClient", idClient);
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var orders = new Orders();

                    orders.CustomerID = dr[0].ToString();
                    orders.CompanyName = dr[1].ToString();
                    orders.OrderID = Convert.ToInt32(dr[2]);
                    orders.OrderDate = Convert.ToDateTime(dr[3]);
                    orders.RequiredDate = Convert.ToDateTime(dr[4]);
                    orders.UnitPrice = Convert.ToDecimal(dr[5]);

                    list.Add(orders);
                }
            }
            return list;
        }
    }
}
