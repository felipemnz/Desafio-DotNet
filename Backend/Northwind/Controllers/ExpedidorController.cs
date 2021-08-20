using BusinessLogic.ExpedidorBll;
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
    public class ExpedidorController : ControllerBase
    {
        private IExpedidorBll _expedidorBll;

        public ExpedidorController(IExpedidorBll expedidorBll)
        {
            _expedidorBll = expedidorBll;
        }

        [HttpPost]
        public bool Post([FromBody] Shippers model) => _expedidorBll.CadastrarExpedidor(model);

        [HttpGet]
        public List<Shippers> Get() => _expedidorBll.ListarExpedidores();
    }
}
