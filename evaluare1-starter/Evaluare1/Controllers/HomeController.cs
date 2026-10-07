using Microsoft.AspNetCore.Mvc;

namespace Evaluare1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titlu = "Evaluarea nr. 1";
            return View();
        }
    }
}
