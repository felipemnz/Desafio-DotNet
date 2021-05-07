using Desafio.Net.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Net.DAL
{
	public class OrdersDAL
	{
		private readonly NorthwindContext _context;

		public OrdersDAL(NorthwindContext contexto)
		{
			_context = contexto;
		}
		public async Task<IEnumerable<Order>> GetOrdersByShipper(int id)
		{
			var dados = await _context.Orders.Include("ShipViaNavigation").Where(x => x.ShipVia == id).ToListAsync();
			return dados;
		}

		public async Task<IEnumerable<Order>> GetOrdersByCustomer(string id)
		{
			return await _context.Orders.Include("Customer").Where(x => x.CustomerId == id).ToListAsync();
		}

	}
}
