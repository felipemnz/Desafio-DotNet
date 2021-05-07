using Desafio.Net.DAL;
using Desafio.Net.Models;
using Desafio.Net.Models.VO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.Net.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeesController : ControllerBase
	{
		private readonly NorthwindContext _context;

		public EmployeesController(NorthwindContext context)
		{
			_context = context;
		}

		// GET: api/Employees
		[HttpGet]
		public async Task<IEnumerable<EmployeesSales>> GetEmployees(DateTime startDate, DateTime endDate)
		{
			var employeesDAL = new EmployeesDAL(_context);

			return await employeesDAL.GetEmployees(startDate, endDate);
		}
	}
}
