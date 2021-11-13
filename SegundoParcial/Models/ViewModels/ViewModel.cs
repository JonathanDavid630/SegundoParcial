using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SegundoParcial.Models.ViewModels
{
    public class ViewModel
    {
        public int StudentId { get; set; }

        [Display(Name = " Segundo Nombre ")]
        [Required(ErrorMessage = "Este campo es necesario")]
        public string LastName { get; set; }

        [Display(Name = "Primer Nombre ")]
        [Required(ErrorMessage = "Este campo es necesario")]
        public string FirstMidName { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "Este campo es necesario")]
        public Nullable<DateTime> EnrrollmentsDate { get; set; }
    }
}