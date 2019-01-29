using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRetailNetwork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRetailNetwork.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RetailNetworkController : Controller	{
			private readonly RetailNetworkContext _context;

			public RetailNetworkController(RetailNetworkContext context) {
				_context = context;

				if (_context.Dealers.Count() == 0)	{
					// Create a new TodoItem if collection is empty,
					// which means you can't delete all TodoItems.
					_context.Dealers.Add(new CarDealer { Name = "Dealer Test" });
					_context.SaveChanges();
				}
			}

			// GET: api/Todo
			[HttpGet]
			public async Task<ActionResult<IEnumerable<CarDealer>>> GetTodoItems()	{
				return await _context.Dealers.ToListAsync();
			}

			// GET: api/Todo/5
			[HttpGet("{id}")]
			public async Task<ActionResult<CarDealer>> GetTodoItem(long id)	{
				var todoItem = await _context.Dealers.FindAsync(id);

				if (todoItem == null) {
					return NotFound();
				}

				return todoItem;
			}
	}
	
}
