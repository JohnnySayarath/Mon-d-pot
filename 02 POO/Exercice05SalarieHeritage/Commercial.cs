
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice05SalarieHeritage.Classes;

internal class Commercial : Salarie
{
    private decimal _commission;
    private decimal _chiffreAffaire;

    public decimal Commission
    {
        get => _commission;
        set
        {
            _commission = value / 100 ;
        }
    }
    public decimal ChiffreAffaire { get => _chiffreAffaire; set => _chiffreAffaire = value; }
    public string Matricule { get; set; } = "000";
    public string Nom { get; set; } = "Salarié par défaut";
    public string Service { get; set; } = "Service par défaut";
    public string Categorie { get; set; } = "Catégorie par défaut";
    //public Commercial() : base()
    //{

    //}

    public Commercial( string nom, string matricule, string service, string categorie, decimal salaire,decimal commission, decimal chiffreAffaire) : base( nom, matricule, service,  categorie,  salaire)
    {
        Nom = nom;
        Matricule = matricule;
        Service = service;
        Categorie = categorie;
        Commission = commission;
        ChiffreAffaire = chiffreAffaire;
        Salaire = salaire;
    }

    public override void AfficherSalaire()
    {
        Console.WriteLine($"Le salaire de {Nom} est de {Salaire + (ChiffreAffaire * Commission)} euros");
    }

}