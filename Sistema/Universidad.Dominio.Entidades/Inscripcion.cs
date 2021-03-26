using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio.Entidades
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public virtual Alumno Alumno { get; set; }
        public int CursadoId { get; set; }
        public virtual Cursado Cursado { get; set; }
    }
}
