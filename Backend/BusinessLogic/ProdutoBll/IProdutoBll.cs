using DataAccess.Model;
using Mapping.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ProdutoBll
{
    public interface IProdutoBll
    {
        bool CriarProduto(Product model);
        List<Product> ListarProduto(ProdutoFiltro filtro);
    }
}
