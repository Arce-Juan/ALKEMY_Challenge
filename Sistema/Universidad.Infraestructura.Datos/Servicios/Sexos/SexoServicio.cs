using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;
using Universidad.Infraestructura.Datos.UoW;

namespace Universidad.Infraestructura.Datos.Servicios.Sexos
{
    public class SexoServicio : ISexoServicio
    {
        ISexoRepositorio _sexoRepositorio;
        private IUnitOfWork _unitOfWork;

        public SexoServicio(ISexoRepositorio sexoRepositorio, IUnitOfWork unitOfWork)
        {
            _sexoRepositorio = sexoRepositorio;
            _unitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        
        public void Agragar(Sexo sexo)
        {
            _unitOfWork.SexoRepositorio.Create(sexo);
            _unitOfWork.Save();
        }

        public void Modificar(Sexo sexo)
        {
            _unitOfWork.SexoRepositorio.Update(sexo);
            _unitOfWork.Save();
        }

        public void Eliminar(int id)
        {
            _unitOfWork.SexoRepositorio.Delete(id);
            _unitOfWork.Save();
        }

        public Sexo ObtenerPorId(int id)
        {
            return _unitOfWork.SexoRepositorio.Get(id);
        }

        public IEnumerable<Sexo> ObtenerTodos()
        {
            return _unitOfWork.SexoRepositorio.GetAll();
        }
    }
}
