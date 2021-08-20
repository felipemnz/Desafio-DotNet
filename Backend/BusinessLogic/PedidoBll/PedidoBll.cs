using DataAccess.Model;
using Mapping.Filter;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.PedidoBll
{
    public class PedidoBll : IPedidoBll
    {
        private readonly IMongoCollection<Orders> _ordersRepository;

        public PedidoBll(INorthwindDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DataBaseName);

            _ordersRepository = database.GetCollection<Orders>("Orders");
        }
        public bool CriarPedido(Orders model)
        {
            try
            {
                _ordersRepository.InsertOne(model);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public List<Orders> ListarPedidos(PedidoFilter filtro)
        {
            if (filtro.id_cliente != null || filtro.id_expedidor != null)
            {
                if (filtro.id_cliente != null && filtro.id_expedidor != null)
                {
                    return _ordersRepository.Find(x => x.Shipper_id == filtro.id_expedidor
                                                    && x.Customer_id == filtro.id_cliente).ToList();
                }

                if (filtro.id_cliente == null && filtro.id_expedidor != null)
                {
                    return _ordersRepository.Find(x => x.Shipper_id == filtro.id_expedidor).ToList();
                }

                if (filtro.id_cliente != null && filtro.id_expedidor == null)
                {
                    return _ordersRepository.Find(x => x.Customer_id == filtro.id_cliente).ToList();
                }

                return new List<Orders>();
            }
            else
            {
                return new List<Orders>();
            }
        }
    }
}
