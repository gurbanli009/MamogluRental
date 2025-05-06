using Microsoft.AspNetCore.Mvc;

namespace MamogluRental.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
