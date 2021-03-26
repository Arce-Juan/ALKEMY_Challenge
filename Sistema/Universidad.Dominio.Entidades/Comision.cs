using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio.Entidades
{
    public class Comision
    {
        public int Id { get; set; }
        public int NumeroAula { get; set; }
        public string Nombre { get; set; }
        public virtual Carrera Carrera { get; set; }
    }
}
