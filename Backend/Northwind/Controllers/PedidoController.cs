using BusinessLogic.PedidoBll;
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
    public class PedidoController : ControllerBase
    {
        private IPedidoBll _pedidoBll;
        public PedidoController(IPedidoBll pedidoBll)
        {
            _pedidoBll = pedidoBll;
        }

        [HttpPost]
        public bool Post([FromBody] Orders model) => _pedidoBll.CriarPedido(model);

        [HttpGet]
        public List<Orders> Get([FromQuery] PedidoFilter filtro) => _pedidoBll.ListarPedidos(filtro);
    }
}
