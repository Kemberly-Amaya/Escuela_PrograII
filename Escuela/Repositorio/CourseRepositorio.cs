﻿using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class CourseRepositorio : ICourse
    {
        private AplicattionDbContext app;

        public CourseRepositorio(AplicattionDbContext app) {

            this.app = app;
        }

        public void Insertar(Course c)
        {
            app.Add(c);
            app.SaveChanges();
        }
       
        public void Buscar(Course c) {
            //esto equivale a un where de base de datos
            app.Courses.Find(c);
 
        
        }
        public void Delete(Course c)
        {
            app.Courses.Remove(c);

        }
        public ICollection<Course> ListarCursos()
        {
            return app.Courses.ToList();

        }
    }
}
