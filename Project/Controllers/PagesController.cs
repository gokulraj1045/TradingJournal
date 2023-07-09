using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class PagesController : Controller
    {
		public IActionResult Chart()
		{
			return View();
		}

		public IActionResult Calendar()
		{

			return View();

		}
	}
}
