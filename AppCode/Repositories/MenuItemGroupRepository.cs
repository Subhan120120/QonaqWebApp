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
    public class MenuItemGroupRepository : AbstractRepository, IRepository<MenuItemGroup>
    {
        public MenuItemGroupRepository(QonaqContext db)
            : base(db) { }  

        public MenuItemGroup Add(MenuItemGroup entity)
        {
            db.MenuItemGroups.Add(entity);
            return entity;
        }

        public async Task<MenuItemGroup> AddAsync(MenuItemGroup entity)
        {
            await db.MenuItemGroups.AddAsync(entity);
            return entity;
        }

        public IEnumerable<MenuItemGroup> AddRange(IEnumerable<MenuItemGroup> entities)
        {
            db.MenuItemGroups.AddRange(entities);
            return entities;
        }

        public async Task<IEnumerable<MenuItemGroup>> AddRangeAsync(IEnumerable<MenuItemGroup> entities)
        {
            await db.MenuItemGroups.AddRangeAsync(entities);
            return entities;
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

        public async Task<ICollection<MenuItemGroup>> GetAllAsync(Expression<Func<MenuItemGroup, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return await db.MenuItemGroups.Where(predicate).ToListAsync();
            }
            return await db.MenuItemGroups.ToListAsync();
        }

        public MenuItemGroup GetById(int id)
        {
            return db.MenuItemGroups.Find(id);
        }

        public async Task<MenuItemGroup> GetByIdAsync(int id)
        {
            return await db.MenuItemGroups.FindAsync(id);
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
