using Evaluare1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Evaluare1.Controllers
{
    public class CurseController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titlu = "Curse de autobuz";
            return View(BazaCurse.Lista);
        }
    }
}