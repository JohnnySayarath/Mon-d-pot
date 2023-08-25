using Demo10CreationGeneriques.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10CreationGeneriques.Classes
{
    internal class Ordinateur : IDemarable
    {
        public void Arreter()
        {
            Console.WriteLine("L'ordinateur s'éteint");
        }

        public void Demarrer()
        {
            Console.WriteLine("L'ordinateur s'allume");
        }
    }
}
