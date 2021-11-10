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
    public class StudentController : Controller
    {
        private IStudent istudent;

        public IActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insertar(StudentViewModel studentView, IStudent istudent)
        {
            this.istudent = istudent;
            if (!ModelState.IsValid)
            {
                return View("Student", studentView);

            }
            else
            {

                Students student = new Students();
                student.StudentId = studentView.StudentId;
                student.FirtsMidName = studentView.FirtsMidName;
                student.LastName = studentView.LastName;
                student.EnrollementsDate = studentView.EnrollementsDate;
                istudent.Insertar(student);

                return View("Index");

            }

        }
    }
}

