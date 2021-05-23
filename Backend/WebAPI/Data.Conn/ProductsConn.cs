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
    public class ProductsConn : Conn
    {
        public List<Products> GetAll(int idForm)
        {
            List<Products> list = new List<Products>();

            using (var con = new SqlConnection(ConnString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

               var cmd = new SqlCommand("sp_get_suplies_byid_product");
               cmd.Parameters.AddWithValue("@SupplierID", idForm);
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var products = new Products();

                    products.SupplierID = Convert.ToInt32(dr[0]);
                    products.CompanyName = dr[1].ToString();
                    products.ProductID = Convert.ToInt32(dr[2]);
                    products.ProductName = dr[3].ToString();
                    products.UnitPrice = Convert.ToDecimal(dr[4]);

                    list.Add(products);
                }
            }
            return list;
        }

    }
}
