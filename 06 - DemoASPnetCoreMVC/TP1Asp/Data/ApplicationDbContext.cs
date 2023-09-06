using Microsoft.EntityFrameworkCore;
using TP1Asp.Models;

namespace TP1Asp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ToDoList> ToDoLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            int lastIndex = 0;
            var toDoLists = new List<ToDoList>()
            {
                new ToDoList() {Id = ++lastIndex, TitleTask = "Faire à manger", Desc = "Cuisiner du poulet aux olives"}
            };

            modelBuilder.Entity<ToDoList>().HasData(toDoLists);
        }
    }


}
