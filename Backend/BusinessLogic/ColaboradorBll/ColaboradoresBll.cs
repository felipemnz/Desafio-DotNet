using DataAccess.Model;
using Mapping.Filter;
using Mapping.ViewModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ColaboradorBll
{
    public class ColaboradoresBll : IColaboradoresBll
    {
        private readonly IMongoCollection<Employees> _employeesRepository;
        private readonly IMongoCollection<Orders> _ordersRepository;

        public ColaboradoresBll(INorthwindDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DataBaseName);

            _employeesRepository = database.GetCollection<Employees>("Employees");
            _ordersRepository = database.GetCollection<Orders>("Orders");
        }

        public bool CriarColaborador(Employees model)
        {
            try
            {
                _employeesRepository.InsertOne(model);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public List<QuantitativoColaboradorVM> ListarColaborador(PeriodoFilter filtro)
        {
            var retorno = new List<QuantitativoColaboradorVM>();

            var colaboradores = _employeesRepository.Find(x => true).ToList();

            colaboradores.ForEach(item => {
                var produtos = _ordersRepository.Find(x => x.Employee_id == item.Employee_id).ToList();
                long count = 0;
                if (produtos.Count > 0)
                {
                    produtos.ForEach(prod => {
                        if (prod.Order_date >= filtro.DataInicial && prod.Order_date <= filtro.DataFinal)
                        {
                            count += 1;
                        }
                    });
                }

                retorno.Add(new QuantitativoColaboradorVM { 
                    Id = item.Employee_id,
                    First_name = item.First_name,
                    Last_name = item.Last_name,
                    Quantity = count
                });
            });

            return retorno;
        }
    }
}
