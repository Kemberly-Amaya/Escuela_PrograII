using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class MostrarDatos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
