using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Universidad.Dominio.Entidades;

namespace Universidad.Presentacion.Web.ViewModels.ProfesorVM
{
    public class IndexViewModel
    {
        public List<Profesor> Profesores { get; set; }
    }
}