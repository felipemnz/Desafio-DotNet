using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    public class EmployeesBusiness
    {
        public List<Employees> GetAllEmployees(DateTime dataI, DateTime dataF)
        {
            return new dbConn.EmployeesConn().GetAll( dataI,  dataF);
        }

    }
}
