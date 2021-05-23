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
    public class EmployeesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EmployeesController> _logger;
        public EmployeesController(ILogger<EmployeesController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Obter todas as Employees.
        /// </summary>
        /// <response code="200">Lista de Employees obtidas com sucesso.</response>
        /// <response code="500">Erro ao obter a lista de Categories.</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<Employees>), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get(DateTime dataI, DateTime dataF)
        {
            try
            {
                return Ok(new business.EmployeesBusiness().GetAllEmployees( dataI,  dataF));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
