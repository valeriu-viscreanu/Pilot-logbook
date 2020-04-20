using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Smart.TestApi.DataLayer
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
    }
}