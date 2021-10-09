using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface ICourse
    {
        //ira a la db y insertara los datos
        void Insertar(Course c);
    }
}
