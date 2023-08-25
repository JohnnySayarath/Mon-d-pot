using Demo01EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EFCore.Data
{
    // Le DbContext est l'élément le plus important pour utiliser EFCore, il permet d'établir le lien
    // entre l'application et la BDD
    internal class ApplicationDbContext : DbContext
    {
        // Dans une application qui n'utilise pas l'injection de dépendances (cf ASP.NET CCore) on utilise
        // ce constructeur
        public ApplicationDbContext() : base()
        {
            
        }

        // En ajoutant des propriétés de type DbSet<T>, on va pouvoir crée et lier des tables de base de
        // données avec notre application
        public DbSet<Student> Students { get; set; }

        // La méthode OnConfiguring est appelée à la configuration d'EFCore pour notre application
        // on pourra changer son fonctionnement via l asurcharge de cette méthode (override)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\EFCore;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data Seed => "graine" de la base de données, données initiales lors de l'application de la 
            // migration correspondante
            var studentDefault = new Student()
            {
                Id = 1000,
                Firstname = "Défaut",
                Lastname = "Défaut",
                Phone = "0607080901",
                Email = "défaut@hotmail.fr"

            };

            modelBuilder.Entity<Student>().HasData(studentDefault);
        }
    }
}
