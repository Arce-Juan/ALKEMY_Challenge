using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;
using Universidad.Infraestructura.Datos.Contexto;
using Universidad.Infraestructura.Datos.Servicios.Personas;

namespace Universidad.Infraestructura.Datos.Repositorios
{
    public class PersonaRepositorio : IPersonaRepositorio
    {
        private readonly IUniversidadContexto _dbContext;

        public PersonaRepositorio(IUniversidadContexto dbContext)
        {
            _dbContext = dbContext;
        }

        public Persona ObtenerProfesoresActivos(int id)
        {
            return _dbContext.Person
                .Where(x => x.Id == id)
                .Include(x => x.Sexo)
                .FirstOrDefault();
        }
    }
}
