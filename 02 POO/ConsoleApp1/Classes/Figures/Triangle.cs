using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercie08Figure.Classes.Figures
{
    internal class Triangle : Figure
    {
        /*
         *                   A          
         * 
         *      -hauteur
         * 
         *              C         B
         *           -base/2   +base/2
         */
        public double Hauteur { get; set; }
        public double Base { get; set; }

        public Point B => new Point(A.X + +Base/2, A.Y - Hauteur);
        public Point C => new Point(A.X + -Base/2, A.Y - Hauteur);

        public Triangle(Point a, double baase, double hauteur) : base(a)
        {
            Base = baase;
            Hauteur = hauteur;
        }

        public Triangle(double x, double y, double baase, double hauteur) : base(x,y)
        {
            Base = baase;
            Hauteur = hauteur;
        }

        public override string ToString()
        {
            return $"Coordonées du rectangle ABCD  (Base = {Base}) (Hauteur = {Hauteur})" +
                "\nA = " + A +
                "\nB = " + B +
                "\nC = " + C; 
        }
    }
}
