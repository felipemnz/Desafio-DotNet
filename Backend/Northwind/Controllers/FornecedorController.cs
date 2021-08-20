using BusinessLogic.FornecedorBll;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Northwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController: ControllerBase
    {
        private IFornecedorBll _fornecedorBll;

        public FornecedorController(IFornecedorBll fornecedorBll)
        {
            _fornecedorBll = fornecedorBll;
        }

        [HttpPost]
        public bool Post([FromBody] Suppliers model) => _fornecedorBll.CadastrarFornecedor(model);


        [HttpGet]
        public List<Suppliers> Get() => _fornecedorBll.ListarFornecedores();
    }
}
