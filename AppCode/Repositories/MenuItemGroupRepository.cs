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
    public class MenuItemGroupRepository : AbstractRepository, IRepository<MenuItemGroup>
    {
        public MenuItemGroupRepository(QonaqContext db)
            : base(db) { }  

        public MenuItemGroup Add(MenuItemGroup entity)
        {
            db.MenuItemGroups.Add(entity);
            return entity;
        }

        public void Delete(MenuItemGroup entity)
        {
            db.MenuItemGroups.Remove(entity);
        }

        public MenuItemGroup Edit(MenuItemGroup entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IQueryable<MenuItemGroup> GetAll(Expression<Func<MenuItemGroup, bool>> predicate = null)
        {
            if (predicate!= null)
            {
                return db.MenuItemGroups.Where(predicate);
            }
            return db.MenuItemGroups.AsQueryable();
        }

        public MenuItemGroup GetById(int id)
        {
            return db.MenuItemGroups.Find(id);
        }

        public MenuItemGroup Update(MenuItemGroup entity)
        {
            db.Update(entity);
            return entity;
        }

        public IEnumerable<MenuItemGroup> UpdateRange(IEnumerable<MenuItemGroup> entities)
        {
            db.UpdateRange(entities);
            return entities;
        }
    }
}
