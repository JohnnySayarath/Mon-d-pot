using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercie08Figure.Classes.Figures
{
    internal abstract class Figure
    {
        public Point A { get; private set; }

        protected Figure(Point a)
        {
            A = a;
        }
        protected Figure(double x, double y)
        {
            A = new Point(x, y);
        }
    }
}
