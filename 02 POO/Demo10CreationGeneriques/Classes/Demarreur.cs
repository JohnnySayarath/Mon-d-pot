using Demo10CreationGeneriques.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10CreationGeneriques.Classes
{
    //internal class Demarreur<T> where T : IEnumerable<string>
    internal class Demarreur<TypeDemarable> where TypeDemarable : IDemarable // Demarreur est une CLASSE GENERIQUE
    {
        public void DemarreCetteChose(TypeDemarable choseADemarrer)
        {
            choseADemarrer.Demarrer();
        }
    }
}
