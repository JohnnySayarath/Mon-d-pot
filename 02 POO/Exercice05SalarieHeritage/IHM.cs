using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice05SalarieHeritage.Classes;

internal class IHM 
{
    static List<Salarie> employes = new List<Salarie>();

    public static void Start()
    {
        bool quitter = false;

        while (!quitter)
        {
            AfficherMenu();
            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    AjouterEmploye();
                    break;
                case "2":
                    AfficherSalaires();
                    break;
                case "3":
                    RechercherEmploye();
                    break;
                case "0":
                    quitter = true;
                    break;
                default:
                    Console.WriteLine("Choix invalide. Veuillez réessayer.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AfficherMenu()
    {
        Console.WriteLine("===== Gestion des employés =====");
        Console.WriteLine("1) Ajouter un employé");
        Console.WriteLine("2) Afficher les salaires de tous les employés");
        Console.WriteLine("3) Rechercher un employé par le début de son nom");
        Console.WriteLine("0) Quitter");
        Console.Write("Choix : ");
    }

    static void AjouterEmploye()
    {
        Console.WriteLine("1) Ajouter un salarié");
        Console.WriteLine("2) Ajouter un commercial");
        Console.Write("Choix : ");
        string choix = Console.ReadLine();

        switch (choix)
        {
            case "1":
                AjouterSalarie();
                break;
            case "2":
                AjouterCommercial();
                break;
            default:
                Console.WriteLine("Choix invalide. Veuillez réessayer.");
                break;
        }
    }

    static void AjouterSalarie()
    {
        Console.Write("Entrez le nom de l'employé : ");
        string nom = Console.ReadLine();

        Console.Write("Entrez le matricule de l'employé : ");
        string matricule = Console.ReadLine();

        Console.Write("Entrez le service de l'employé : ");
        string service = Console.ReadLine();

        Console.Write("Entrez la catégorie de l'employé : ");
        string categorie = Console.ReadLine();

        Console.Write("Entrez le salaire de l'employé : ");
        decimal salaire = Convert.ToDecimal(Console.ReadLine());

        Salarie salarie = new Salarie(nom, matricule, service, categorie, salaire);
        employes.Add(salarie);

        Console.WriteLine("Salarié ajouté avec succès.");
    }

    static void AjouterCommercial()
    {
        Console.Write("Entrez le nom de l'employé : ");
        string nom = Console.ReadLine();

        Console.Write("Entrez le matricule de l'employé : ");
        string matricule = Console.ReadLine();

        Console.Write("Entrez le service de l'employé : ");
        string service = Console.ReadLine();

        Console.Write("Entrez la catégorie de l'employé : ");
        string categorie = Console.ReadLine();

        Console.Write("Entrez le salaire de l'employé : ");
        decimal salaire = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Entrez la commission du commercial : ");
        decimal commission = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Entrez le chiffre d'affaires du commercial : ");
        decimal chiffreAffaire = Convert.ToDecimal(Console.ReadLine());

        Commercial commercial = new Commercial(nom, matricule, service, categorie, salaire, commission, chiffreAffaire) ;
        employes.Add(commercial);

        Console.WriteLine("Commercial ajouté avec succès.");
    }

    static void AfficherSalaires()
    {
        Console.WriteLine("Salaires des employés :");

        foreach (Salarie employe in employes)
        {
            employe.AfficherSalaire();
        }
    }

    static void RechercherEmploye()
    {
        Console.Write("Entrez le début du nom de l'employé à rechercher : ");
        string debutNom = Console.ReadLine();

        bool employeTrouve = false;

        foreach (Salarie employe in employes)
        {
            if (employe.Nom.StartsWith(debutNom))
            {
                employe.AfficherSalaire();
                employeTrouve = true;
            }
        }

        if (!employeTrouve)
        {
            Console.WriteLine("Aucun employé trouvé avec ce début de nom.");
        }
    }
}