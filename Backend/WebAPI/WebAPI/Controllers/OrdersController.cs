using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<OrdersController> _logger;
        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Obter todas as Produtcts.
        /// </summary>
        /// <response code="200">Lista de Categories obtidas com sucesso.</response>
        /// <response code="500">Erro ao obter a lista de Categories.</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<Orders>), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get(string idClient)
        {
            try
            {
                return Ok(new business.OrdersBusiness().GetAllOrders(idClient));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
