using DataAccess.Model;
using Mapping.Filter;
using Mapping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ColaboradorBll
{
    public interface IColaboradoresBll
    {
        bool CriarColaborador(Employees model);

        List<QuantitativoColaboradorVM> ListarColaborador(PeriodoFilter filtro);
    }
}
