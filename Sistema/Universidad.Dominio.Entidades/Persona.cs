using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public virtual Sexo Sexo { get; set; }
    }
}
