using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Infraestructura.Datos.Repositorios
{
    public interface IRepositorioGenerico<T> where T : class
    {
        T Get(long id);
        IEnumerable<T> GetAll();
        void Create(T newDataObject);
        void Update(T changedDataObject);
        void Delete(long id);
    }
}
