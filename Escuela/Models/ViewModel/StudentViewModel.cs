using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Models.ViewModel
{
    public class StudentViewModel
    {
        [Display(Name = "StudentId")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int StudentId { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string LastName { get; set; }

        [Display(Name = "FirtsMidName ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string FirtsMidName { get; set; }

        [Display(Name = "EnrollementsDate")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime EnrollementsDate { get; set; }

    }
}
