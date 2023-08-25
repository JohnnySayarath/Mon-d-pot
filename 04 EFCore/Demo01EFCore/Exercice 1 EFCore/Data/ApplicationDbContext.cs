using Exercice_1_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercice_1_EFCore.Data
{
    // le DbContext est l'élément le plus important pour utiliser EFCore, il permet d'établir le lien entre l'application et la BDD
    internal class ApplicationDbContext : DbContext
    {
        // dans une application qui n'utilise pas l'injection de dépendances (cf ASP.NET Core) on utilisera ce constructeur
        public ApplicationDbContext() : base()
        {

        }
        // en ajoutant des propriétés de type DbSet<T>, on va pouvoir créé et lier des tables de base de donnée avec notre application
        public DbSet<Adress> Adresses { get; set; }

        // la méthode OnConfiguring est appelée à la configuration d'EFCore pour notre application,
        // on pourra changer son fonctionnement via la surcharge de cette méthode
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // la méthode UseSqlServer de l'optionsBuilder sert à préciser une connexion à une BDD SQL Server avec sa chaine de connexion
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\exo1EFCore;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data Seed => "graine" de la base de données, données initiales lors de l'application de la 
            // migration correspondante
            var adresseDefault = new Adress()
            {
                Id = 1000,
                Numero_voie = "Rue de ...",
                Complement = "",
                Intitule_voie = "Maison",
                Commune = "Commune par défaut",
                CodePostal = "00000"
            };

            modelBuilder.Entity<Adress>().HasData(adresseDefault);
        }

    }
}
