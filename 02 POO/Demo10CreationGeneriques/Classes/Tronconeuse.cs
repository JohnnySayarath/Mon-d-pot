using Demo10CreationGeneriques.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10CreationGeneriques.Classes
{
    internal class Tronconeuse : IDemarable
    {
        public void Arreter()
        {
            Console.WriteLine("La tronçonneuse s'éteint.");
        }

        public void Demarrer()
        {
            Console.WriteLine("Bvvvrrrt !");
        }
    }
}
