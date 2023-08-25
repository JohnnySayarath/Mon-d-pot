using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06HeritageOverrideAbstract
{
    internal class Chien : Mammifere
    {
        public string Race { get; set; }

        public Chien(string nom, bool estVivant, string genre, string race) : base(nom, estVivant, genre)
        {
            Race = race;
        }
        public new void Crier()
        {
            Console.WriteLine("Le chien aboie");
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Le chien se déplace à 4 pattes");
        }
    }
}
