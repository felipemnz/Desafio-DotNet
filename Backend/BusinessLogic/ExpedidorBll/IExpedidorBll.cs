using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ExpedidorBll
{
    public interface IExpedidorBll
    {
        bool CadastrarExpedidor(Shippers model);
        List<Shippers> ListarExpedidores();
    }
}
