using Microsoft.EntityFrameworkCore;
using QonaqWebApp.AppCode.Interface;
using QonaqWebApp.Models.Context;
using QonaqWebApp.Models.Entity;
using System.Linq;

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

        public IQueryable<MenuItemGroup> GetAll()
        {
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
    }
}
