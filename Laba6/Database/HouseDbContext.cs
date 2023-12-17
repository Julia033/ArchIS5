using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Database
{
    class HouseDbContext : DbContext
    {
        public HouseDbContext() : base("name=HouseDataBase") { }
        public DbSet<Models.House> Participants { get; set; }
        public DbSet<Models.City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.House>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Models.City>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Models.City>().HasMany(p => p.Houses).WithOptional(p => p.Cities).HasForeignKey(p => p.CityID);
            modelBuilder.Entity<Models.House>().ToTable("Houses");
        }
    }
}
