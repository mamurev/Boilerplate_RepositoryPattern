using Company.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Company.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
