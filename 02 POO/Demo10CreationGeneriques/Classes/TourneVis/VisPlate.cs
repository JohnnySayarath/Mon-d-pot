using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10CreationGeneriques.Classes.TourneVis
{
    internal class VisPlate : Vis
    {
        public override void Visser()
        {
            Console.WriteLine("je visse la vis plate");
        }
    }
}
