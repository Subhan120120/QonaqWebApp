using Microsoft.EntityFrameworkCore;
using QonaqWebApp.AppCode.Interface;
using QonaqWebApp.Models.Context;
using QonaqWebApp.Models.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace QonaqWebApp.AppCode.Repositories
{
    public class MenuItemRepository : AbstractRepository, IRepository<MenuItem>
    {
        public MenuItemRepository(QonaqContext db)
            : base(db) { }


        public MenuItem Add(MenuItem entity)
        {
            db.MenuItems.Add(entity);
            return entity;
        }

        public void Delete(MenuItem entity)
        {
            db.MenuItems.Remove(entity);
        }

        public MenuItem Edit(MenuItem entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IQueryable<MenuItem> GetAll(Expression<Func<MenuItem, bool>> predicate = null)
        {
            if (predicate!=null)
            {
                return db.MenuItems.Where(predicate);
            }
            return db.MenuItems.AsQueryable();
        }

        public MenuItem GetById(int id)
        {
            return db.MenuItems.Find(id);
        }

        public MenuItem Update(MenuItem entity)
        {
            db.Update(entity);
            return entity;
        }
    }
}
