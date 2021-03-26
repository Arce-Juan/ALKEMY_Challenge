using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio.Entidades
{
    public class Cursado
    {
        public int Id { get; set; }
        public int CupoMaximo { get; set; }
        public int CupoActual { get; set; }
        public virtual CicloLectivo Ciclo { get; set; }
        public virtual Modalidad Modalidad { get; set; }
        public virtual Comision Comision { get; set; }
        public virtual Materia Materia { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Administrativo Administrativo { get; set; }
        public virtual ICollection<Inscripcion> ListaInscripciones { get; set; }
    }
}
