using DataAccess.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ExpedidorBll
{
    public class ExpedidorBll : IExpedidorBll
    {
        private readonly IMongoCollection<Shippers> _shippersRepository;

        public ExpedidorBll(INorthwindDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DataBaseName);

            _shippersRepository = database.GetCollection<Shippers>("Shippers");
        }

        public bool CadastrarExpedidor(Shippers model)
        {
            try
            {
                _shippersRepository.InsertOne(model);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Shippers> ListarExpedidores()
        {
            return _shippersRepository.Find(x => true).ToList();
        }
    }
}
