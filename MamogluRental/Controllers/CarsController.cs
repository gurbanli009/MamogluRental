using Microsoft.AspNetCore.Mvc;

namespace MamogluRental.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
