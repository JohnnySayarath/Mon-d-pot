using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03Polymorphisme1
{
    internal class Enclos
    {
        private List<Dinosaur> _dinosaursList = new List<Dinosaur>();

        public string Nom { get; set; }
        public int Taille { get; set; }
        public int NbDinoMax { get; set; }

        public Enclos(string nom, int taille, int nbDinoMax)
        {
            Nom = nom;
            Taille = taille;
            NbDinoMax = nbDinoMax;
        }

        public bool AjouterDino(Dinosaur dinosaur)
        {
            if (_dinosaursList.Count == NbDinoMax)
                return false;

            _dinosaursList.Add(dinosaur);
            return true;
        }

        public bool AjouterDino()
        {
            return AjouterDino(new Dinosaur());
        }

        public bool AjouterDino(string nom, int age, string espece, bool peutVoler)
        {
            return AjouterDino(new Dinosaur(nom, age, espece, peutVoler));
        }

        public override string ToString()
        {
            string enclosString = $"L'enclos \"{Nom}\" de taille {Taille} et pouvant accueillir {NbDinoMax} dinosaures au maximum contient les dinosaurs suivants :\n";
            foreach (Dinosaur dinosaur in _dinosaursList)
            {
                enclosString += "\t-" + dinosaur + "\n";
                //enclosString += "\t-" + dinosaur.ToString() + "\n";
            }
            return enclosString;
        }
    }
}
