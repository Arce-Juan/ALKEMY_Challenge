using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;
using Universidad.Infraestructura.Datos.Contexto;
using Universidad.Infraestructura.Datos.Repositorios;

namespace Universidad.Infraestructura.Datos.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private UniversidadContexto _context;
        private IRepositorioGenerico<Profesor> _profesorRepositorio;

        public UnitOfWork(UniversidadContexto context)
        {
            _context = context;
        }

        public IRepositorioGenerico<Profesor> ProfesorRepositorio
        {
            get
            {
                return _profesorRepositorio = _profesorRepositorio ?? new RepositorioGenerico<Profesor>(_context);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
