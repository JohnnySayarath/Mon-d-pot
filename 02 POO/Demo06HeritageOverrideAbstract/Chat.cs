using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06HeritageOverrideAbstract
{
    internal sealed class Chat : Mammifere
    {
        public bool EstDomestique { get; set; }

        public Chat(string nom, bool estVivant, string genre, bool domestique) : base(nom, estVivant, genre)
        {
            EstDomestique = domestique;
        }

        public new void Crier() // si on cherche à remplacer une méthode sans virtual, il est préférable d'utiliser le mot clé new
        {
            Console.WriteLine("Le chat miaule");
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Le chat se déplace à 4 pattes");
        }

        public override void Allaiter()
        {
            base.Allaiter();
            Console.WriteLine("méthode allaiter du chat");
        }
    }
}
