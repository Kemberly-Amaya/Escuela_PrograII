using Escuela.Dominio;
using Escuela.Models;
using Escuela.Models.ViewModel;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private IRollements irollements;

        public HomeController(ILogger<HomeController> logger, ICourse icourse, IRollements irollements)

        {
            this.icourse = icourse;
            this.irollements = irollements;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listado = irollements.UnionDeTablas();
            _ = listado;
            return View(listado);
            //OTRA FORMA DE OBTENER EL JSON -------------------
            //var DandoFormatoJson = icourse.ListarCursos();

            ////enviar hacia el front end una variable anonima -- data
            //return Json(new { data = DandoFormatoJson });
            //-------------------------------------------------

        }
        //Deserealizacion
        public IActionResult GetAllForJoinJsonLinq()
        {
            //Llamar sobre que queremos hacer la consulta
            var listado = irollements.UnionDeTablas();
            //Consulta no a base de datos sino que estara estipulada sbre arreglos
            var CombinacionDeArreglos = (from union in listado
                                         select new
                                         {
                                             union.Course.Title,
                                             union.Students.LastName,
                                             union.Students.FirtsMidName,
                                             union.Grade
                                         }).ToList();

            return Json(new { CombinacionDeArreglos});


        }
        public ActionResult ComboBox() {
            var InformationOftheComboBox = icourse.ListarCursos();

            List<SelectListItem> lista = new List<SelectListItem>();

            foreach (var iterarinformacion in InformationOftheComboBox) {
                lista.Add(new SelectListItem
                    {
                        Text = iterarinformacion.Title,
                        Value = Convert.ToString(iterarinformacion.CourseId)
                    }

                    );
                ViewBag.estado = lista;

            }
            return View();
        
        }
        
            public IActionResult Insertar(CouseViewModel couseView)
        {
            if (!ModelState.IsValid) {
                return View("Index",couseView);

            }
            else
            {
                for (int i=0; i <= 100; i++)
                {
                    Course course = new Course();
                    course.Title = couseView.Title;
                    course.Credits = couseView.Credits;
                    icourse.Insertar(course);
                }
                   

                    return View("Index");
                
            }
          
        }
        public IActionResult GetAll()
        {
            var DandoFormatoJson = icourse.ListarCursos();

            //enviar hacia el front end una variable anonima -- data
            return Json(new{ data = DandoFormatoJson });

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
