using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;
using Universidad.Infraestructura.Datos.UoW;

namespace Universidad.Infraestructura.Datos.Servicios.Personas
{
    public class PersonaServicio : IPersonaServicio
    {
        IPersonaRepositorio _personaRepositorio;
        private IUnitOfWork _unitOfWork;

        public PersonaServicio(IPersonaRepositorio personaRepositorio, IUnitOfWork unitOfWork)
        {
            _personaRepositorio = personaRepositorio;
            _unitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Agragar(Persona persona)
        {
            _unitOfWork.PersonaRepositorio.Create(persona);
            _unitOfWork.Save();
        }

        public void Modificar(Persona persona)
        {
            _unitOfWork.PersonaRepositorio.Update(persona);
            _unitOfWork.Save();
        }

        public void Eliminar(int id)
        {
            _unitOfWork.PersonaRepositorio.Delete(id);
            _unitOfWork.Save();
        }

        public Persona ObtenerPorId(int id)
        {
            return _unitOfWork.PersonaRepositorio.Get(id);
        }

        public IEnumerable<Persona> ObtenerTodos()
        {
            return _unitOfWork.PersonaRepositorio.GetAll();
        }

        public Persona ObtenerCompleto(int id)
        {
            return _personaRepositorio.ObtenerProfesoresActivos(id);
        }
    }
}
