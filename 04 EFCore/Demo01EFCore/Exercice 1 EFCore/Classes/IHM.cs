using Exercice_1_EFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice_1_EFCore.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace Exercice_1_EFCore.Models
{
    
    internal static class IHM
    {

        static void Menu()
        {
            Console.WriteLine("=== MENU PRINCIPAL ===\n\n");
            Console.WriteLine("1. Voir les adresses\n");
            Console.WriteLine("2. Ajouter une adresse\n");
            Console.WriteLine("3. Editer une adresse\n");
            Console.WriteLine("4. Supprimer une adresse\n");
            Console.WriteLine("0. Quitter le programme\n");
        }
        public static void Start()
        {
            string choix;
            do
            {
                Menu();
                Console.Write("\n\nSélectionner votre choix : ");
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        AfficherAdresses();
                        break;
                    case "2":
                        AjouterAdresse();
                        break;
                    case "3":
                        ModifierAdresse();
                        break;
                    case "4":
                        SupprimerAdresse();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Erreur saisie !");
                        break;
                }
            } while (choix != "0");
        }

        static void AjouterAdresse()
        {
            Console.Write("\nMerci de saisir le numéro de voie : ");
            string numeroVoie = Console.ReadLine();
            //ad.Numero_voie = numeroVoie == "" ? ad.Numero_voie : numeroVoie;

            Console.Write("\nMerci de saisir le complément (Appt, Ter, Bis etc...) : ");
            string complement = Console.ReadLine();

            Console.Write("\nMerci de saisir l'intitulé de la voie (rue de ...) : ");
            string intituleVoie = Console.ReadLine();

            Console.Write("\nMerci de saisir la Commune : ");
            string commune = Console.ReadLine();

            Console.Write("\nMerci de saisir le code postal : ");
            string codePostal = Console.ReadLine();

            using var context = new ApplicationDbContext();     // Tout le temps déclarer cette variable context pour utiliser Tools
            
            Adress adresse = new Adress
            {
                Numero_voie = numeroVoie,
                Complement = complement,
                Intitule_voie = intituleVoie,
                Commune = commune,
                CodePostal = codePostal
            };
            context.Adresses.Add(adresse);            // préparation de l'ajout d'une adresse (INSERT)
            context.SaveChanges();                    // sauvegarder les changements
        }




        static void AfficherAdresses()
        {
            using var context = new ApplicationDbContext();
            Console.WriteLine("\n\nRécupération de toutes les adresses\n\n");
            List<Adress> adresses = context.Adresses.ToList();              // Lister tout mes étudiants avec le ToList()
            foreach (var a in adresses)
            {
                Console.WriteLine($"Adresse : {a.Id}, {a.Numero_voie}, {a.Complement}, {a.Intitule_voie}, {a.Commune}, {a.CodePostal}");
            }
        }
        private static void ModifierAdresse()
        {
            using var context = new ApplicationDbContext();

            Console.Write("\n\nMerci de saisir l'id de l'adresse à modifier : ");
            int adresseiD = int.Parse(Console.ReadLine());

            Adress adresse = context.Adresses.FirstOrDefault(a => a.Id == adresseiD);
            Console.WriteLine("\nSaisir les modifications à apporter :\n\n");

            Console.Write("\nSaisir le nouveau numéro de voie :");
            string nouvelleVoie = Console.ReadLine();                                                       // Déclarer une nouvelle variable pour modif
            adresse.Numero_voie = nouvelleVoie == "" ? adresse.Numero_voie : nouvelleVoie;                  // Faire un ternaire avec la nouvelle variable
                                                                                                            // pour ne pas écraser l'ancienne donnée
            Console.Write("Saisir le nouveau complément d'adresse (Bis, Ter, Appt ...) :");
            string nouveauComplement = Console.ReadLine();
            adresse.Complement = nouveauComplement == "" ? adresse.Complement : nouveauComplement;

            Console.Write("Saisir le nouvel intitulé de voie :");
            string nouvelIntituleVoie = Console.ReadLine();
            adresse.Intitule_voie = nouvelIntituleVoie == "" ? adresse.Intitule_voie : nouvelIntituleVoie;

            Console.Write("Saisir la nouvelle Commune :");
            string nouvelleCommune = Console.ReadLine();
            adresse.Commune = nouvelleCommune == "" ? adresse.Commune : nouvelleCommune;

            Console.Write("Saisir le nouveau numéro de Code Postal :");
            string nouveauCodePostal = Console.ReadLine();
            adresse.CodePostal = nouveauCodePostal == "" ? adresse.CodePostal : nouveauCodePostal;

            context.Adresses.Update(adresse);
            context.SaveChanges();

           
        }

        static void SupprimerAdresse()
        {
            using var context = new ApplicationDbContext();

            Console.Write("\n\nMerci de saisir l'ID de l'adresse : \n");
            int adresseiD = int.Parse(Console.ReadLine());
            Adress adresse = context.Adresses.FirstOrDefault(a => a.Id == adresseiD);
            Console.WriteLine($"\nAdresse ID {adresse.Id} : {adresse.Numero_voie}, {adresse.Complement}, {adresse.Intitule_voie}, {adresse.Commune}, {adresse.CodePostal}\n");
            Console.WriteLine("Une confirmation : O/N");
            Console.Write("");
            string choix = Console.ReadLine();
            if (choix.ToUpper() == "O")
            {
                context.Adresses.Remove(adresse);
                context.SaveChanges();
            }
            else
                Console.WriteLine("La requête est annulée");
           
        }

    }
}


