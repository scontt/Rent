using Microsoft.AspNetCore.Mvc;

namespace Rent.Controllers
{
    public class RentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
