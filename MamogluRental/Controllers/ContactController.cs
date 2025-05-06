using Microsoft.AspNetCore.Mvc;

namespace MamogluRental.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
