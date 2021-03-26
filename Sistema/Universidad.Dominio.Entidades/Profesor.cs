using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio.Entidades
{
    public class Profesor
    {
        public int Id { get; set; }
        public bool Activo { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
