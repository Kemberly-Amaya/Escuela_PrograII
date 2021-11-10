using Escuela.Dominio;
using Escuela.Models.ViewModel;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class CourseController : Controller
    {
        private ICourse icourse;

        public IActionResult Course()
        {
            return View();
        }
        public IActionResult CourseRegistrar()
        {
            return View();
        }

        // INSERTAR CURSOS
        [HttpPost]
        public IActionResult InsertarCursos(CourseViewModel couseView, ICourse icourse)
        {
            this.icourse = icourse;
            if (!ModelState.IsValid)
            {
                return View("Course", couseView);

            }
            else
            {
                    Course course = new Course();
                    course.Title = couseView.Title;
                    course.Credits = couseView.Credits;
                    icourse.InsertarCursos(course);
               


                return View("Index");

            }

        }
     

    }

}
