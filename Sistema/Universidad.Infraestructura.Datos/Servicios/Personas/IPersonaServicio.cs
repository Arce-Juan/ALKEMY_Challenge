using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;

namespace Universidad.Infraestructura.Datos.Servicios.Personas
{
    public interface IPersonaServicio
    {
        void Agragar(Persona persona);
        void Modificar(Persona persona);
        void Eliminar(int id);
        Persona ObtenerPorId(int id);
        IEnumerable<Persona> ObtenerTodos();
        Persona ObtenerCompleto(int id);
    }
}
