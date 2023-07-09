using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class LandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
