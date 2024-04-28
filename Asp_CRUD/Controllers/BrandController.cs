using Asp_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Asp_CRUD.Controllers
{
    public class BrandController : Controller
    {
        //Data Inyect 
        private readonly PubContext _context;
        
        //Return Inyect
        public BrandController(PubContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Brands.ToListAsync());
        }
    }
}
