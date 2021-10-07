using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{
    public class Students
    {
        [Key] //atributo reconosca llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int StudentId { get; set; }

        public string LastName {get; set;}

        public string FirtsMidName { get; set;}

        public DateTime EnrollementsDate { get; set; }


        //Hcer relacion con la tb enrollements
        public ICollection<Enrollement> Enrollements { get; set; }




    }
}
