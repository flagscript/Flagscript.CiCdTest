using Microsoft.AspNetCore.Mvc;

namespace Flagscript.CiCdTest.Controllers
{
    public class HomeController : Controller
    {
		[Route("/", Name = "Home")]
		public IActionResult Index()
        {
            return View();
        }
    }
}