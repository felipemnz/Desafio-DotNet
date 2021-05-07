using Desafio.Net.Models;
using Desafio.Net.Models.VO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Net.DAL
{
	public class EmployeesDAL
	{
		private readonly NorthwindContext _context;

		public EmployeesDAL(NorthwindContext contexto)
		{
			_context = contexto;
		}

		public async Task<IEnumerable<EmployeesSales>> GetEmployees(DateTime startDate, DateTime endDate)
		{
			var data = await _context.Employees.Include("Orders").Select(x => new EmployeesSales()
			{
				EmployeeId = x.EmployeeId,
				FirstName = x.FirstName,
				LastName = x.LastName,
				Title = x.Title,
				TitleOfCourtesy = x.TitleOfCourtesy,
				QtyOrders = x.Orders.Where(y => y.OrderDate >= startDate && y.OrderDate <= endDate).Count()
			}).ToListAsync();


			return data;
		}

	}
}
