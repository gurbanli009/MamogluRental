using Microsoft.AspNetCore.Mvc;

namespace MamogluRental.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
