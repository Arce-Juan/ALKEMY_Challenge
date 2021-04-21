using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;
using Universidad.Infraestructura.Datos.UoW;

namespace Universidad.Infraestructura.Datos.Servicios.Profesores
{
    public class ProfesorServicio : IProfesorServicio
    {
        IProfesorRepositorio _profesorRepositorio;
        private IUnitOfWork _unitOfWork;

        public ProfesorServicio(IProfesorRepositorio profesorRepositorio, IUnitOfWork unitOfWork)
        {
            _profesorRepositorio = profesorRepositorio;
            _unitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void AgragarProfesor(Profesor profesor)
        {
            _unitOfWork.ProfesorRepositorio.Create(profesor);
            _unitOfWork.Save();
        }

        public void ModificarProfesor(Profesor profesor)
        {
            _unitOfWork.PersonaRepositorio.Update(profesor.Persona);
            var persoa = _unitOfWork.ProfesorRepositorio.Get(profesor.Persona.Id);
            _unitOfWork.ProfesorRepositorio.Update(profesor);
            _unitOfWork.Save();
        }

        public void EliminarProfesor(int id)
        {
            _unitOfWork.ProfesorRepositorio.Delete(id);
            _unitOfWork.Save();
        }

        public Profesor ObtenerPorId(int id)
        {
            return _unitOfWork.ProfesorRepositorio.Get(id);
        }

        public IEnumerable<Profesor> ObtenerTodos()
        {
            return _unitOfWork.ProfesorRepositorio.GetAll();
        }

        public IEnumerable<Profesor> ObtenerProfesoresActivos(bool activo)
        {
            return _profesorRepositorio.ObtenerProfesoresActivos(activo);
        }

       
    }
}
