using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Repository.Abstractions
{
    public interface IGenericAppService<T>
    {
        IQueryable<T> Get(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            params Expression<Func<T, object>>[] includeProperties);

        T GetById(params object[] id); //uses params keyword which allows searching tables with composite primary key.

        Task<T> GetByIdAsync(params object[] id);

        T FirstOrDefault(Expression<Func<T, bool>> filter = null);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> filter = null);

        void Insert(T entity);

        T InsertandReturn(T entity);

        void Update(T entityToUpdate);

        void Delete(params object[] id);

        void Delete(T entityToDelete);
    }
}
