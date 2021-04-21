using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;

namespace Universidad.Infraestructura.Datos.Servicios.Profesores
{
    public interface IProfesorRepositorio
    {
        IEnumerable<Profesor> ObtenerProfesoresActivos(bool activo);
        //void ActualizarDatos(Profesor _profesor);
    }
}
