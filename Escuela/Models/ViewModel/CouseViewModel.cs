using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Models.ViewModel
{
    public class CouseViewModel
    {
        [Display(Name = "Curso")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Title { get; set;}

        [Display(Name = "Credito")]
        [Range (0,int.MaxValue, ErrorMessage ="No válido")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Credits { get; set; }

    }
}
