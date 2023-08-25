using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05Heritage
{
    internal class Chien : Mammifere
    {
        public string Race { get; set; }


        public Chien(string nom, bool estVivant, string genre, string race) : base(nom, estVivant, genre)
        {
            Race = race;
        }
        public void Crier()
        {
            Console.WriteLine("Le chien aboie");
        }
    }
}
