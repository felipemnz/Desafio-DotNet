using DataAccess.Model;
using Mapping.Filter;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ProdutoBll
{
    public class ProdutoBll : IProdutoBll
    {
        private readonly IMongoCollection<Product> _produtoRepository;

        public ProdutoBll(INorthwindDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DataBaseName);

            _produtoRepository = database.GetCollection<Product>("Product");
        }
        public bool CriarProduto(Product model)
        {
            try
            {
                _produtoRepository.InsertOne(model);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public List<Product> ListarProduto(ProdutoFiltro filtro)
        {
            if (filtro.Id_categoria != null || filtro.Id_fornecedor != null)
            {
                if (filtro.Id_categoria != null && filtro.Id_fornecedor != null)
                {
                    return _produtoRepository.Find(x => x.Category_id == filtro.Id_categoria
                                                     && x.Supplier_id == filtro.Id_fornecedor).ToList();
                }

                if(filtro.Id_categoria != null && filtro.Id_fornecedor == null)
                {
                    return _produtoRepository.Find(x => x.Category_id == filtro.Id_categoria).ToList();
                }

                if (filtro.Id_categoria == null && filtro.Id_fornecedor != null)
                {
                    return _produtoRepository.Find(x => x.Supplier_id == filtro.Id_fornecedor).ToList();
                }

                return new List<Product>();
            }
            else
            {
                return new List<Product>();
            }
        }
    }
}
