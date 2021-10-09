using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Data
{     //Hacer herencia de DbContex
    public class AplicattionDbContext :DbContext
    {
        //Constructor vacio que gace referencia a als opciones de DbContex
        public AplicattionDbContext(DbContextOptions<AplicattionDbContext> options) 
            : base(options)
        {
       
        }
      
    }
}
