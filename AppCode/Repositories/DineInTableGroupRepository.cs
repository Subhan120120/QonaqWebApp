using Microsoft.EntityFrameworkCore;
using QonaqWebApp.AppCode.Infrastructure;
using QonaqWebApp.Models.Context;
using QonaqWebApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace QonaqWebApp.AppCode.Repositories
{
    public class DineInTableGroupRepository : AbstractRepository, IRepository<DineInTableGroup>
    {
        public DineInTableGroupRepository(QonaqContext db)
: base(db) { }

        public DineInTableGroup Add(DineInTableGroup entity)
        {
            db.DineInTableGroups.Add(entity);
            return entity;
        }

        public void Delete(DineInTableGroup entity)
        {
            db.DineInTableGroups.Remove(entity);
        }

        public DineInTableGroup Edit(DineInTableGroup entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IQueryable<DineInTableGroup> GetAll(Expression<Func<DineInTableGroup, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return db.DineInTableGroups.Where(predicate);
            }
            return db.DineInTableGroups.AsQueryable();
        }

        public DineInTableGroup GetById(int id)
        {
            return db.DineInTableGroups.Find(id);
        }

        public DineInTableGroup Update(DineInTableGroup entity)
        {
            db.Update(entity);
            return entity;
        }

        public IEnumerable<DineInTableGroup> UpdateRange(IEnumerable<DineInTableGroup> entities)
        {
            db.UpdateRange(entities);
            return entities;
        }
    }
}
