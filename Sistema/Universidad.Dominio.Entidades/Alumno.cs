using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio.Entidades
{
    public class Alumno
    {
        public int Id { get; set; }
        public int Legajo { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
