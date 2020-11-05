using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QonaqWebApp.AppCode.Infrastructure
{
    public interface IRepository<T>
        where T : class
    {
        T Add(T entity);
        T Edit(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        T GetById(int id);
        T Update(T entity);
        int SaveChanges();
    }
}
