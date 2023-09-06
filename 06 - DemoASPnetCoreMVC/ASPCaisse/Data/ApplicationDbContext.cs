using Microsoft.EntityFrameworkCore;
using TPASPCaisse.Models;

namespace TPASPCaisse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasKey(pc => new { pc.Id, pc.CategoryId });

            //int lastIndex = 0;
            var categories = new List<Category>()
            {
                new Category() { Id = 1, Name = "Fruits" },
                new Category() { Id = 2, Name = "Légumes"}
            };

            modelBuilder.Entity<Category>().HasData(categories);

            int lastIndex = 0;
            var products = new List<Product>
            {
                new Product() {Id = ++lastIndex, Name = "Banane", Description = "Fruit qui vient du bananier", Price = 1, Quantity = 100, CategoryId = 1},
                new Product() {Id = ++lastIndex, Name = "Fraise", Description = "Fruit qui vient du fraisier", Price = 1, Quantity = 100, CategoryId = 1}
            };

            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}
