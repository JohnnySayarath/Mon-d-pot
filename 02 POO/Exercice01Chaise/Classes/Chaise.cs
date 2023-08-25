using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01Chaise.Classes
{
    internal class Chaise
    {
        private int _nbPieds;
        private string _materiau;
        private string _couleur;

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public int NbPieds { get => _nbPieds; set => _nbPieds = value; }
        public string Materiau { get => _materiau; set => _materiau = value; }

        public Chaise()
        {
            Console.WriteLine("Je construit une chaise avec le constructeur par défaut !");
            NbPieds = 4;
            Materiau = "Bois";
            Couleur = "Blanche";
        }

        public Chaise(int nbPieds, string materiau, string couleur)
        {
            Console.WriteLine("Je construit une chaine avec l'autre constructeur !");
            Couleur = couleur;
            NbPieds = nbPieds;
            Materiau = materiau;
        }

        public void Afficher()
        {
            //Console.WriteLine(ToString());
            //Console.WriteLine(this.ToString());

            Console.WriteLine(this); //appelle le ToString implicitement pour write la representation textuelle de la chaise
        }

        public override string ToString() // override remplace le comportement de base de la méthode Object.ToString(), cette méthode donne la représentation textuelle de l'instance 
        {
            return $"Je suis une Chaise, avec {NbPieds} pieds en {Materiau} et de couleur {Couleur}";
        }
    }
}
