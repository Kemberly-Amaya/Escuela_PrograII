using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class EnrollementRepository: IRollements
    {
        private AplicattionDbContext db;

        public EnrollementRepository(AplicattionDbContext db)
        {

            this.db = db;
        }

        //implementara la interfaz de enrollement
        public List<Enrollement> UnionDeTablas() {
            //var union = db.Enrollements.Include(e => e.Students).ToList();
            //return union;


            //Union de tres tablas
            //en enrollemente se encuentra la informacionde las otras tablas
            var union = db.Enrollements.Include(e => e.Students).Include(c =>c.Course).ToList();
            return union;

        }

    }
}
