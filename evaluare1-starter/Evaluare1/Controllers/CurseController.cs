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

        public IActionResult Detalii(int id)
        {
            Cursa cursaGasita = null;

            foreach (var cursa in BazaCurse.Lista)
            {
                if (cursa.Id == id)
                {
                    cursaGasita = cursa;
                    break;
                }
            }

            if (cursaGasita == null)
            {
                return NotFound();
            }

            return View(cursaGasita);
        }
    }
}