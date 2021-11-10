using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class StudentRepository: IStudent
    {
        private AplicattionDbContext app;

        public StudentRepository(AplicattionDbContext app)
        {

            this.app = app;
        }

        public void Insertar(Students e)
        {
            app.Add(e);
            app.SaveChanges();
        }
        public List<Students> ListOfStudent()
        {
            return app.Students.ToList();
        }
    }
}
