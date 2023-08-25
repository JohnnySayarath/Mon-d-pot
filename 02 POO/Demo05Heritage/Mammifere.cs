using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05Heritage
{
    internal class Mammifere : Animal
    {
        public string Genre { get; set; }
        public Mammifere(string nom, bool estVivant, string genre) : base(nom, estVivant)
        {
            Genre = genre;
        }

        public Mammifere() : base("nom par défaut", false)
        {
            Genre = "Masculin";
        }

        public void Respirer()// ici on vient MASQUER la méthode Respirer => pas recommandé
        {
            Console.WriteLine("Le mammifere respire");
        }
    }
}
