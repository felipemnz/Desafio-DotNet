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
    public class EmployeesConn : Conn
    {
        public List<Employees> GetAll(DateTime dataI,DateTime dataF)
        {
            List<Employees> list = new List<Employees>();

            using (var con = new SqlConnection(ConnString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                var cmd = new SqlCommand("sp_get_Employees_OrderDate");
                cmd.Parameters.AddWithValue("@DataI", dataI);
                cmd.Parameters.AddWithValue("@DataF", dataF);
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var employees = new Employees();


                    employees.EmployeeID = Convert.ToInt32(dr[0]);
                    employees.LastName = dr[1].ToString();
                    employees.FirstName = dr[2].ToString();
                    employees.QuantPedidos = Convert.ToInt32(dr[3]);

                    list.Add(employees);
                }
            }
            return list;
        }

    }
}
