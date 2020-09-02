using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.AppCode.Interface
{
    public interface IRepository<T>
        where T : class
    {
        T Add(T entity);
        T Edit(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        T GetById(int id);
        T Update(T entity);
        int SaveChanges();
    }
}
