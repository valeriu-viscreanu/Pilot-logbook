using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Smart.TestApi.DataLayer
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext context;
        public GenericRepository(DbContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {
            T existing = context.Set<T>().Find(id);
            if (existing != null) context.Set<T>().Remove(existing);
        }

        public IEnumerable<T> Get()
        {
            return context.Set<T>().AsEnumerable<T>();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate).AsEnumerable<T>();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.Set<T>().Attach(entity);
        }
    }
}
