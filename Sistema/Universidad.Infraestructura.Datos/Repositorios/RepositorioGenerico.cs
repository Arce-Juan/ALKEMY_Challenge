using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Infraestructura.Datos.Contexto;

namespace Universidad.Infraestructura.Datos.Repositorios
{
    class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {
        protected readonly UniversidadContexto dbContext;

        public RepositorioGenerico(UniversidadContexto ctx)
        {
            dbContext = ctx;
        }

        public void Create(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        public void Delete(long id)
        {
            TEntity _entity = dbContext.Set<TEntity>().Find(id);
            dbContext.Set<TEntity>().Remove(_entity);
        }

        public TEntity Get(long id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }

        
    }
}
