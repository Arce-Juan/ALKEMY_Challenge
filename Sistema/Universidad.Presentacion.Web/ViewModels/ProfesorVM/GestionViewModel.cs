using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Universidad.Dominio.Entidades;

namespace Universidad.Presentacion.Web.ViewModels.ProfesorVM
{
    public class GestionViewModel
    {
        public string TipoGestion { get; set; }
        public Profesor Profesor { get; set; }
        [Required]
        [Display(Name = "Dni")]
        public string TxtDni { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string TxtApellido { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string TxtNombre { get; set; }
        [Required]
        [Display(Name = "Nacimiento")]
        public string TxtNacimiento { get; set; }

        [Required]
        [Display(Name = "Activo")]
        public string TxtActivo { get; set; }
        public IEnumerable<SelectListItem> Activos
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem { Text = "SI", Value = "SI"},
                    new SelectListItem { Text = "NO", Value = "NO"}
                };
            }
        }
        [Required]
        [Display(Name = "Sexo")]
        public string TxtSexo { get; set; }
        public IEnumerable<SelectListItem> Sexos { get; set; }

    }
}