using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio.Entidades
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Nivel> ListaNiveles { get; set; }
        public virtual ICollection<Comision> ListaComisiones { get; set; }
    }
}
