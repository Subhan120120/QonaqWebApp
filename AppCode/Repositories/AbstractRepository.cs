﻿using QonaqWebApp.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.AppCode.Repositories
{
    abstract public class AbstractRepository
    {
        protected readonly IdealContext db;
        public AbstractRepository(IdealContext db)
        {
            this.db = db;
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await db.SaveChangesAsync();
        }

    }
}
