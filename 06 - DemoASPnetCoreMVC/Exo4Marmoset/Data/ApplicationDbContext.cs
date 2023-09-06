using Exo4Marmoset.Models;
using Microsoft.EntityFrameworkCore;

namespace Exo4Marmoset.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //public ApplicationDbContext()
        //{

        //}

        public DbSet<Marmoset> Marmosets { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source = (localdb)\aspexo5; Integrated Security = True") ;
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            int lastIndex = 0;
            var marmosets = new List<Marmoset>()
            {
                new Marmoset {Id = ++lastIndex, Name = "Babouche", Age = 2 }
            };
            modelBuilder.Entity<Marmoset>().HasData(marmosets);
        }

    }
}
