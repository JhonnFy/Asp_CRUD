using Microsoft.AspNetCore.Mvc;

namespace Asp_CRUD.Controllers
{
	public class BeerController1 : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
