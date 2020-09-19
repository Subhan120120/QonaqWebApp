using Microsoft.EntityFrameworkCore;
using QonaqWebApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.Context
{
    public class QonaqContext : DbContext
    {
        public QonaqContext(DbContextOptions<QonaqContext> options)
            : base(options){}

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuItemGroup> MenuItemGroups { get; set; }
    }
}
