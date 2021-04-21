using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Infraestructura.Datos.Contexto;
using Universidad.Infraestructura.Datos.Servicios.Sexos;

namespace Universidad.Infraestructura.Datos.Repositorios
{
    public class SexoRepositorio : ISexoRepositorio
    {
        private readonly IUniversidadContexto _dbContext;

        public SexoRepositorio(IUniversidadContexto dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
