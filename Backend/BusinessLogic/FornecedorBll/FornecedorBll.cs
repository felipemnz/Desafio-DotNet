using DataAccess.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.FornecedorBll
{
    public class FornecedorBll : IFornecedorBll
    {
        private readonly IMongoCollection<Suppliers> _suppliersRepository;

        public FornecedorBll(INorthwindDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DataBaseName);

            _suppliersRepository = database.GetCollection<Suppliers>("Suppliers");
        }
        public bool CadastrarFornecedor(Suppliers model)
        {
            try
            {
                _suppliersRepository.InsertOne(model);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public List<Suppliers> ListarFornecedores()
        {
            return _suppliersRepository.Find(x => true).ToList();
        }
    }
}
