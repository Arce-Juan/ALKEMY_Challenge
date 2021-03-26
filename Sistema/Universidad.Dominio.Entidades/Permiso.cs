using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio.Entidades
{
    public class Permiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int PerfilId { get; set; }
        public virtual Perfil Perfil { get; set; }
    }
}
