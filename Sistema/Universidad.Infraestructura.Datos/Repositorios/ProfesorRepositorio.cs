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

        /*
        public Profesor ObtenerProfesorConRelaciones(int id)
        {
            return _dbContext.Professor
                .Where(x => x.Activo == true)
                .Include(x => x.Persona)
                .Include("Persona.Sexo")
        }
        */

        public IEnumerable<Profesor> ObtenerProfesoresActivos(bool activo)
        {
            return _dbContext.Professor
                .Where(x => x.Activo == true)
                .Include(x => x.Persona)
                .Include("Persona.Sexo")
                .ToList();
        }
        /*
        public void ActualizarDatos(Profesor _profesor)
        {
            var contexto = new UniversidadContexto();
            var profesor = contexto.Professor
                .Where(x => x.Id == _profesor.Id)
                .First();

            profesor.Activo = _profesor.Activo;
            profesor.Persona = _profesor.Persona;
            profesor.Persona.Sexo = _profesor.Persona.Sexo;

            contexto.SaveChanges();
        }
        */
    }
}
