using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio.Entidades
{
    public class Administrativo
    {
        public int Id { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
