using DataAccess.Model;
using Mapping.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.PedidoBll
{
    public interface IPedidoBll
    {
        bool CriarPedido(Orders model);
        List<Orders> ListarPedidos(PedidoFilter filtro);
    }
}
