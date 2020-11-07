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
    public class ReservationRepository : AbstractRepository, IRepository<Reservation>
    {
        public ReservationRepository(QonaqContext db)
    : base(db) { }

        public Reservation Add(Reservation entity)
        {
            db.Reservations.Add(entity);
            return entity;
        }

        public void Delete(Reservation entity)
        {
            db.Reservations.Remove(entity);
        }

        public Reservation Edit(Reservation entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IQueryable<Reservation> GetAll(Expression<Func<Reservation, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return db.Reservations.Where(predicate);
            }
            return db.Reservations.AsQueryable();
        }

        public Reservation GetById(int id)
        {
            return db.Reservations.Find(id);
        }

        public Reservation Update(Reservation entity)
        {
            db.Update(entity);
            return entity;
        }

        public IEnumerable<Reservation> UpdateRange(IEnumerable<Reservation> entities)
        {
            db.UpdateRange(entities);
            return entities;
        }
    }
}
