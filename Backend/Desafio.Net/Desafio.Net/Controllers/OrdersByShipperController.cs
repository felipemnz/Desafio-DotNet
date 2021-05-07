using Desafio.Net.DAL;
using Desafio.Net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.Net.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersByShipperController : ControllerBase
	{
		private readonly NorthwindContext _context;

		public OrdersByShipperController(NorthwindContext context)
		{
			_context = context;
		}

		// GET: api/Orders
		[HttpGet("{id}")]
		public async Task<IEnumerable<Order>> GetOrdersByShipper(int id)
		{
			var ordersDAL = new OrdersDAL(_context);

			return await ordersDAL.GetOrdersByShipper(id);
		}
	}
}
