using DataAccess.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CategoriaBll
{
    public class CategoriaBll : ICategoriaBll
    {
        private readonly IMongoCollection<Categories> _categoryRepository;

        public CategoriaBll(INorthwindDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DataBaseName);

            _categoryRepository = database.GetCollection<Categories>("Categories");
        }
        public bool CadastrarCategoria(Categories model)
        {
            try{
                _categoryRepository.InsertOne(model);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public List<Categories> ListarCategorias()
        {
            return _categoryRepository.Find(x => true).ToList();
        }
    }
}
