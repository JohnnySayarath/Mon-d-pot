using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercie08Figure.Classes.Figures
{
    internal class Rectangle : Figure
    {
        /*            +longueur
         *          A           B
         * -largeur
         *          D           c
         */

        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Point B => new Point(A.X + Longueur, A.Y);
        public Point C => new Point(A.X + Longueur, A.Y - Largeur);
        public Point D => new Point(A.X, A.Y - Largeur);


        public Rectangle(Point a, double largeur, double longueur) : base(a)
        {
            Largeur = largeur;
            Longueur = longueur;
        }
        public Rectangle(double x, double y, double largeur, double longueur) :base(x,y)
        {
            Largeur = largeur;
            Longueur = longueur;
        }

        public override string ToString()
        {
            return $"Coordonées du rectangle ABCD (Largeur = {Largeur}) (Longueur = {Longueur}" +
                "\nA = " + A +
                "\nB = " + B +
                "\nC = " + C +
                "\nD = " + D;
        }

    }
}
