using BusinessLogic.CategoriaBll;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private ICategoriaBll _categoriaBll;

        public CategoriaController(ICategoriaBll categoriaBll)
        {
            _categoriaBll = categoriaBll;
        }

        [HttpPost]
        public bool Post([FromBody] Categories model) => _categoriaBll.CadastrarCategoria(model);


        [HttpGet]
        public List<Categories> Get() => _categoriaBll.ListarCategorias();
    }

}
