using Microsoft.AspNetCore.Mvc;

namespace MamogluRental.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
