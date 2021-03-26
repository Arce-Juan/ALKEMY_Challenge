using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;
using Universidad.Infraestructura.Datos.Contexto;
using Universidad.Infraestructura.Datos.Servicios.Profesores;

namespace Universidad.Infraestructura.Datos.Repositorios
{
    public class ProfesorRepositorio : IProfesorRepositorio
    {
        private readonly IUniversidadContexto _dbContext;

        public ProfesorRepositorio(IUniversidadContexto dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Profesor> ObtenerProfesoresActivos(bool activo)
        {
            return _dbContext.Professor
                .Where(x => x.Activo == true)
                .Include(x => x.Persona)
                .Include("Persona.Sexo")
                .ToList();
        }
    }
}
