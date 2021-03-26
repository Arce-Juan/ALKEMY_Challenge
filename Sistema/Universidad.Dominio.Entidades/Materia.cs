using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio.Entidades
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalles { get; set; }
        public int NivelId { get; set; }
        public virtual Nivel Nivel { get; set; }
    }
}
