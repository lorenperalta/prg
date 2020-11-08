using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prg.Models;

namespace prg.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Registro objRegistro)
        {
            if(ModelState.IsValid){
                return RedirectToAction("Confirmacion");
            }
            return View(objRegistro);
        }

        public IActionResult Confirmacion()
        {
            return View();
        }

    }
}
