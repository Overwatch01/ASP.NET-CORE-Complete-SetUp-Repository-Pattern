using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Repository.Abstractions;
using Infrastructure.Repository.Abstractions;

namespace BusinessLogic.Repository
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class, new()
    {
        protected IGenericRepository<TEntity> _entityRepository { get; }
        public GenericService(IGenericRepository<TEntity> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return _entityRepository.Get();
        }

        public TEntity GetById(params object[] id)
        {
            return _entityRepository.GetById(id);
        }

        public async Task<TEntity> GetByIdAsync(params object[] id)
        {
            return await _entityRepository.GetByIdAsync(id);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter = null)
        {
            return _entityRepository.FirstOrDefault();
        }

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return _entityRepository.FirstOrDefaultAsync();
        }

        public void Insert(TEntity entity)
        {
            _entityRepository.Insert(entity);
        }

        public TEntity InsertandReturn(TEntity entity)
        {
            return _entityRepository.InsertandReturn(entity);
        }

        public void Update(TEntity entityToUpdate)
        {
            _entityRepository.Update(entityToUpdate);
        }

        public void Delete(params object[] id)
        {
            _entityRepository.Delete(id);
        }

        public void Delete(TEntity entityToDelete)
        {
            _entityRepository.Delete(entityToDelete);
        }
    }
}
