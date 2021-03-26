using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio.Entidades
{
    public class Nivel
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int CarreraId { get; set; }
        public virtual Carrera Carrera { get; set; }
        public virtual ICollection<Materia> ListaMaterias { get; set; }
    }
}
