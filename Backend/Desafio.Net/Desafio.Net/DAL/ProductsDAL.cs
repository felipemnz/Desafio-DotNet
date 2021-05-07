using Desafio.Net.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Net.DAL
{
	public class ProductsDAL
	{
		private readonly NorthwindContext _context;

		public ProductsDAL(NorthwindContext contexto)
		{
			_context = contexto;
		}
		public async Task<IEnumerable<Product>> GetProductsByCategory(int id)
		{
			return await _context.Products.Include("Supplier").Include("Category").Where(x => x.CategoryId == id).ToListAsync();
		}
		public async Task<IEnumerable<Product>> GetProductsBySupplier(int id)
		{
			return await _context.Products.Include("Supplier").Include("Category").Where(x => x.SupplierId == id).ToListAsync();

		}
	}
}
