using DataAccess.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ClienteBll
{
    public class ClienteBll : IClienteBll
    {
        private readonly IMongoCollection<Customers> _clientsRepository;

        public ClienteBll(INorthwindDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DataBaseName);

            _clientsRepository = database.GetCollection<Customers>("Customers");
        }

        public bool CriarCliente(Customers model)
        {
            try
            {
                _clientsRepository.InsertOne(model);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public List<Customers> ListarClientes()
        {
            return _clientsRepository.Find(x => true).ToList();
        }
    }
}
