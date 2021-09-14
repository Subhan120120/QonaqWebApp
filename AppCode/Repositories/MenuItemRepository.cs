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
    public class MenuItemRepository : AbstractRepository, IRepository<MenuItem>
    {
        public MenuItemRepository(QonaqContext db)
            : base(db) { }


        public MenuItem Add(MenuItem entity)
        {
            db.MenuItems.Add(entity);
            return entity;
        }

        public async Task<MenuItem> AddAsync(MenuItem entity)
        {
            await db.MenuItems.AddAsync(entity);
            return entity;
        }

        public IEnumerable<MenuItem> AddRange(IEnumerable<MenuItem> entities)
        {
            db.MenuItems.AddRange(entities);
            return entities;
        }

        public async Task<IEnumerable<MenuItem>> AddRangeAsync(IEnumerable<MenuItem> entities)
        {
            await db.MenuItems.AddRangeAsync(entities);
            return entities;
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

        public async Task<ICollection<MenuItem>> GetAllAsync(Expression<Func<MenuItem, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return await db.MenuItems.Where(predicate).ToListAsync();
            }
            return await db.MenuItems.ToListAsync();
        }

        public MenuItem GetById(int id)
        {
            return db.MenuItems.Find(id);
        }

        public async Task<MenuItem> GetByIdAsync(int id)
        {
            return await db.MenuItems.FindAsync(id);
        }

        public MenuItem Update(MenuItem entity)
        {
            db.Update(entity);
            return entity;
        }

        public IEnumerable<MenuItem> UpdateRange(IEnumerable<MenuItem> entities)
        {
            db.UpdateRange(entities);
            return entities;
        }
    }
}
