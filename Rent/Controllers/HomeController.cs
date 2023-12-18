using Microsoft.AspNetCore.Mvc;

namespace Rent.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
