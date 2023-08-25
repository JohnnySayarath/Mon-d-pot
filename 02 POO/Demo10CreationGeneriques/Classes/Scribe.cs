using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10CreationGeneriques.Classes
{
    internal static class Scribe
    {
        public static void EcritPlusieursFois<T1>(T1 choseAEcrire, int nombreDeFois) 
        {
            for (int i = 0; i < nombreDeFois; i++)
                Console.WriteLine(choseAEcrire.ToString());
        }
    }
}
