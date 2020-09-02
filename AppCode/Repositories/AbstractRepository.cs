using QonaqWebApp.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.AppCode.Repositories
{
    abstract public class AbstractRepository
    {
        protected readonly QonaqContext db;

        public AbstractRepository(QonaqContext db)
        {
            this.db = db;
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

    }
}
