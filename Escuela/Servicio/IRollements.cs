using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
   public interface IRollements
    {
        //Aqui se describe como trabajara 
        //Arreglo a iterarr
        List<Enrollement> UnionDeTablas();
    }
}
