using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10CreationGeneriques.Classes.TourneVis
{
    internal class TourneVisPour<T> where T : Vis // Ici c'est la classe qui est générique
    {
        public void Visser(T vis)
        {
            vis.Visser();
        }
    }

    internal class TourneVisAEmbouts
    {
        public void Visser<T>(T vis) where T : Vis // Ici c'est la méthode qui est générique
        {
            vis.Visser();
        }
    }
}
