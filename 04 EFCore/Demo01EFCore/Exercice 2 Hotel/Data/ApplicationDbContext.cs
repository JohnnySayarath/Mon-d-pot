using Exercice02Hotel.Models;
using Exercice02Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static Exercice02Hotel.Models.Chambre;

namespace Exercice02Hotel.Data
{
    // Classe pour gérer la base de données avec Entity Framework Core
    // DbContext qui permet d'établir la connexion entre l'application et la BDD
    internal class ApplicationDbContext : DbContext
    {
        // dans une application qui n'utilise pas l'injection de dépendances (cf ASP.NET Core) on utilisera ce constructeur
        public ApplicationDbContext() : base()
        {
        }
        // en ajoutant des propriétés de type DbSet<T>,
        // on va pouvoir créé et lier des tables de base de donnée avec notre application
        public DbSet<Client> Clients { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationChambre> ReservationChambres { get; set; }
        public DbSet<Chambre> Chambres { get; set; }

        // la méthode OnConfiguring est appelée à la configuration d'EFCore pour notre application,
        // on pourra changer son fonctionnement via la surcharge de cette méthode
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // la méthode UseSqlServer de l'optionsBuilder
            // sert à préciser une connexion à une BDD SQL Server avec sa chaine de connexion
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\Exo2Hotel;Integrated Security=True");
        }

        // Configuration de la connexion à la base de données

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ReservationChambre>()
                .HasKey(rc => new { rc.ChambreNumero, rc.ReservationId });
            modelBuilder.Entity<Chambre>().HasData(new Chambre()
            {
                ChambreNumero = 1,
                NombreLits = 2,
                Statut = StatutChambre.Libre,
                Tarif = 100.50M
            },
            new Chambre()
            {
                ChambreNumero = 2,
                NombreLits = 4,
                Statut = StatutChambre.Nettoyage,
                Tarif = 400.50M
            });
            modelBuilder.Entity<Client>().HasData(new Client()
            {
                Id = 1,
                Nom = "Dupont",
                Prenom = "Pierre",
                NumeroTelephone = "0607080910"
            },
            new Client()
            {
                Id = 2,
                Prenom = "Ihab",
                Nom = "Abadi",
                NumeroTelephone = "0607080911"
            });

        }

    }
}