using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface ICourse
    {
        //Esto se implementara en las otras clases
        //ira a la db y insertara los datos
        void InsertarCursos(Course c);
        void Delete(Course c);
        void Buscar(Course c);

        //metodo definido
        ICollection<Course> ListarCursos();
    }
}
