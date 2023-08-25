using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire
{
    internal class Client : CompteBancaire
    {
        private string _nom;
        private string _prenom;
        private int _identifiant;
        private string _listeDesComptes;
        private string _telephone;


        public string Nom { get ; set ; }
        public string Prenom { get ; set ; }
        public int Identifiant { get ; set ; }
        public string ListeDesComptes { get ; set ; }
        public string Telephone { get ; set ; }

        public Client(string nom, string prenom, int identifiant, string listeDesComptes, string telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Identifiant = identifiant;
            ListeDesComptes = listeDesComptes;
            Telephone = telephone;
        }

        public void AfficherClient()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Le client {Nom} {Prenom} avec l'identifiant {Identifiant} possède {ListeDesComptes}";
        }
    }
}
