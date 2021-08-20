using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CategoriaBll
{
    public interface ICategoriaBll
    {
        bool CadastrarCategoria(Categories model);
        List<Categories> ListarCategorias();
    }
}
