
using Microsoft.AspNetCore.Mvc;

namespace MamogluRental.Controllers
{
    public class CarManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
