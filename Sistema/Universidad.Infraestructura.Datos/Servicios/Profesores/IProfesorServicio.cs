using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;

namespace Universidad.Infraestructura.Datos.Servicios.Profesores
{
    public interface IProfesorServicio
    {
        void AgragarProfesor(Profesor profesor);
        void ModificarProfesor(Profesor profesor);
        void EliminarProfesor(int id);
        Profesor ObtenerPorId(int id);
        IEnumerable<Profesor> ObtenerTodos();
        IEnumerable<Profesor> ObtenerProfesoresActivos(bool activo);
    }
}
