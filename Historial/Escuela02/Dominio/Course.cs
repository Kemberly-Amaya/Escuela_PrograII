using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{
    public class Course

    {
        [Key] //atributo reconosca llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CourseId { get; set; } //llave primaria

        public string Title { get; set; }
        
        public int Credits { get; set; }

        //Hcer relacion con la tb enrollemen
        public ICollection<Enrollement> Enrollements { get; set; }

    }
}
