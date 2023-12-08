using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab6.DataBase
{
    public class House3DbContext : DbContext
    {
        public House3DbContext() : base("name=House3DataBase") { }
        public DbSet<Models.House3> Participants { get; set; }
        //public DbSet<Models.City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.House3>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

    }
}
