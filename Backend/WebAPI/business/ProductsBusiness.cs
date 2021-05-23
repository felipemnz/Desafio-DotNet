using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    public class ProductsBusiness
    {
        public List<Products> GetAllProducts( int idForn)
        {
            return new dbConn.ProductsConn().GetAll( idForn );
        }

    }
}
