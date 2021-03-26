using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;
using Universidad.Infraestructura.Datos.Repositorios;

namespace Universidad.Infraestructura.Datos.UoW
{
    public interface IUnitOfWork
    {
        IRepositorioGenerico<Profesor> ProfesorRepositorio { get; }
        void Save();
    }
}
