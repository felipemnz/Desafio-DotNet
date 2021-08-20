using BusinessLogic.ColaboradorBll;
using DataAccess.Model;
using Mapping.Filter;
using Mapping.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradoresController : ControllerBase
    {
        private IColaboradoresBll _colaboradoresBll;

        public ColaboradoresController(IColaboradoresBll colaboradoresBll)
        {
            _colaboradoresBll = colaboradoresBll;
        }

        [HttpPost]
        public bool Post([FromBody] Employees model) => _colaboradoresBll.CriarColaborador(model);

        [HttpGet]
        public List<QuantitativoColaboradorVM> Get([FromQuery] PeriodoFilter filtro) => _colaboradoresBll.ListarColaborador(filtro);
    }
}
