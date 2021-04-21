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
        IRepositorioGenerico<Persona> PersonaRepositorio { get; }
        IRepositorioGenerico<Profesor> ProfesorRepositorio { get; }
        IRepositorioGenerico<Sexo> SexoRepositorio { get; }
        void Save();
    }
}
