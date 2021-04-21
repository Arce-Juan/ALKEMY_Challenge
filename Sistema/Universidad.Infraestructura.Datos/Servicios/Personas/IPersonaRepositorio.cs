using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;

namespace Universidad.Infraestructura.Datos.Servicios.Personas
{
    public interface IPersonaRepositorio
    {
        Persona ObtenerProfesoresActivos(int id);
    }
}
