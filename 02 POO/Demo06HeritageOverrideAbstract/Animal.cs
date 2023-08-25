using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06HeritageOverrideAbstract
{
    internal abstract class Animal
    {
        public string Nom { get; set; }
        public bool EstVivant { get; set; }
        public Animal(string nom, bool estVivant)
        {
            Nom = nom;
            EstVivant = estVivant;
        }

        public abstract void SeDeplacer();
        public abstract void Respirer();
        public void Crier()
        {
            Console.WriteLine("L'animal crie");
        }
        public void Crier(string crie)
        {
            Console.WriteLine("L'animal crie " + crie);
        }
    }
}
