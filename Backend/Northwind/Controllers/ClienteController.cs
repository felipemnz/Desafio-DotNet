using BusinessLogic.ClienteBll;
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
    public class ClienteController : ControllerBase
    {
        private IClienteBll _clienteBll;

        public ClienteController(IClienteBll clienteBll)
        {
            _clienteBll = clienteBll;
        }

        [HttpPost]
        public bool Post([FromBody] Customers model) => _clienteBll.CriarCliente(model);

        [HttpGet]
        public List<Customers> Get() => _clienteBll.ListarClientes();
    }
}
