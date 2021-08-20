using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ClienteBll
{
    public interface IClienteBll
    {
        bool CriarCliente(Customers model);
        List<Customers> ListarClientes();
    }
}
