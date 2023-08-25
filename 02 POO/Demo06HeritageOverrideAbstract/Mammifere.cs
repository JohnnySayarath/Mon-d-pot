using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06HeritageOverrideAbstract
{
    internal abstract class Mammifere : Animal
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

        public override void Respirer()
        {
            // base.Respirer(); // appeller une méthode du parent => /!\ respirer est abstrait on ne peut pas l'appeller ici
            Console.WriteLine("Le mammifere respire");
        }

        public virtual void Allaiter()
        {
            Console.WriteLine("Le mammifere allaite ses petits");
        }
    }
}
