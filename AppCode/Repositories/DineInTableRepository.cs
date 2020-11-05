using Microsoft.EntityFrameworkCore;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Context;
using QonaqWebApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QonaqWebApp.AppCode.Repositories
{
    public class DineInTableRepository : AbstractRepository, IRepository<DineInTable>
    {
        public DineInTableRepository(QonaqContext db)
    : base(db) { }

        public DineInTable Add(DineInTable entity)
        {
            db.DineInTables.Add(entity);
            return entity;
        }

        public void Delete(DineInTable entity)
        {
            db.DineInTables.Remove(entity);
        }

        public DineInTable Edit(DineInTable entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IQueryable<DineInTable> GetAll(Expression<Func<DineInTable, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return db.DineInTables.Where(predicate);
            }
            return db.DineInTables.AsQueryable();
        }

        public DineInTable GetById(int id)
        {
            return db.DineInTables.Find(id);
        }

        public DineInTable Update(DineInTable entity)
        {
            db.Update(entity);
            return entity;
        }
    }
}
