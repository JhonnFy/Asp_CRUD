using Asp_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Asp_CRUD.Controllers
{
	public class BeerController : Controller
	{

		//Data Inyect 
		private readonly PubContext _context;


        //Return Inyect(Constructor)
        public BeerController(PubContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var beers = _context.Beers.Include(b => b.Brand);
            return View(await beers.ToListAsync());
        }	
		
	}
}
