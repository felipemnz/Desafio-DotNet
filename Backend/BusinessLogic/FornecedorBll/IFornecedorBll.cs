using DataAccess.Model;
using System.Collections.Generic;

namespace BusinessLogic.FornecedorBll
{
    public interface IFornecedorBll
    {
        bool CadastrarFornecedor(Suppliers model); 
        List<Suppliers> ListarFornecedores();
    }
}
