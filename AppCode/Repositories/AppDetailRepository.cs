using Microsoft.EntityFrameworkCore;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Context;
using QonaqWebApp.Models.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace QonaqWebApp.AppCode.Repositories
{
    public class AppDetailRepository : AbstractRepository, IRepository<AppDetail>
    {
        public AppDetailRepository(QonaqContext db)
            : base(db) { }

        public AppDetail Add(AppDetail entity)
        {
            db.AppDetails.Add(entity);
            return entity;
        }

        public void Delete(AppDetail entity)
        {
            db.AppDetails.Remove(entity);
        }

        public AppDetail Edit(AppDetail entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IQueryable<AppDetail> GetAll(Expression<Func<AppDetail, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return db.AppDetails.Where(predicate);
            }
            return db.AppDetails.AsQueryable();
        }

        public AppDetail GetById(int id)
        {
            return db.AppDetails.Find(id);
        }

        public AppDetail Update(AppDetail entity)
        {
            db.Update(entity);
            return entity;
        }
    }
}
