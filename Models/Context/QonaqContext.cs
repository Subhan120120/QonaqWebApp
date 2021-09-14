using Microsoft.EntityFrameworkCore;
using QonaqWebApp.Models.Entity;

namespace QonaqWebApp.Models.Context
{
    public class QonaqContext : DbContext
    {
        public QonaqContext(DbContextOptions<QonaqContext> options)
            : base(options){}


        public DbSet<AppDetail> AppDetails { get; set; }
        public DbSet<DineInTable> DineInTables { get; set; }
        public DbSet<DineInTableGroup> DineInTableGroups { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuItemGroup> MenuItemGroups { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(p => p.IsActive)
                .HasDefaultValue(true); //default value = true
        }

    }
}
