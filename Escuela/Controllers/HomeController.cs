using Escuela.Dominio;
using Escuela.Models;
using Escuela.Models.ViewModel;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
         private ICourse icourse;

        public HomeController(ILogger<HomeController> logger, ICourse icourse)

        {
            this.icourse = icourse;
            _logger = logger;
        }

        public IActionResult Index()
        {
           

            return View();
        }
        public IActionResult Insertar(CouseViewModel couseView)
        {
            if (!ModelState.IsValid) {
                return View("Index",couseView);

            }
            else
            {
                Course course = new Course();
                course.Title = couseView.Title;
                course.Credits = couseView.Credits;
                icourse.Insertar(course);

                return View("Index");

            }
       
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
