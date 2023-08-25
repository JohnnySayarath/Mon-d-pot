using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05Heritage
{
    internal class Chat : Mammifere
    {
        public bool EstDomestique { get; set; }

        public Chat(string nom, bool estVivant, string genre, bool domestique) : base(nom, estVivant, genre)
        {
            EstDomestique = domestique;
        }

        public void Crier()
        {
            Console.WriteLine("Le chat miaule");
        }
    }
}
