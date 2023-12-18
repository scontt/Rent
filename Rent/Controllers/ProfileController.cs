using Microsoft.AspNetCore.Mvc;

namespace Rent.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
