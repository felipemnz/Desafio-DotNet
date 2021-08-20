using BusinessLogic.ProdutoBll;
using DataAccess.Model;
using Mapping.Filter;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoBll _produtoBll;

        public ProdutoController(IProdutoBll produtoBll)
        {
            _produtoBll = produtoBll;
        }

        [HttpPost]
        public bool Post([FromBody] Product model) => _produtoBll.CriarProduto(model);

        [HttpGet]
        public List<Product> Get([FromQuery] ProdutoFiltro filtro) => _produtoBll.ListarProduto(filtro);
    }
}
