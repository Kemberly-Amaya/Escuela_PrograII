using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{ //enum es como una lista, enum tienden a esperar ciertas caracteristicas, que espera recibir la bd  
    public enum Grade { 
    A,B,C,D

    }
    public class Enrollement
    {
        //Describir atestados de la tabal de la db
        [Key] //atributo reconosca llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int EnrollementID { get; set; }

        public int CourseID { get; set; }

        public int StudentsID { get; set; }

        //Haciendo uso de enum "?"---> tomar desicion de algo que viene por el front end
        public Grade? Grade { get; set; }
        //Haciendo o llamando  relacion con la tb Course
        public Course Course { get; set; }

        public Students Students { get; set; }



    }
}
