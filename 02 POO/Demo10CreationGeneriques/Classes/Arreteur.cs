using Demo10CreationGeneriques.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10CreationGeneriques.Classes
{
    internal class Arreteur // la classe n'est PAS GENERIQUE
    {
        public void ArreteCetteChose<T>(T choseAArreter) where T : IDemarable // c'est une METHODE GENERIQUE
        {
            choseAArreter.Arreter();
        }
    }
}
