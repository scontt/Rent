using Microsoft.AspNetCore.Mvc;

namespace Rent.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
