using Desafio.Net.DAL;
using Desafio.Net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.Net.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsBySupplierController : ControllerBase
	{
		private readonly NorthwindContext _context;

		public ProductsBySupplierController(NorthwindContext context)
		{
			_context = context;
		}

		// GET: api/Products
		[HttpGet("{id}")]
		public async Task<IEnumerable<Product>> GetProductsBySupplier(int id)
		{
			var productsDAL = new ProductsDAL(_context);

			return await productsDAL.GetProductsBySupplier(id);

		}

	}
}
