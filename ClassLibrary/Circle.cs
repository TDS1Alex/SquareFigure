using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Circle: Figure
    {
        public double Radius {get;}

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Square()
        {
            if (Radius <= 0) throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным и равняться нулю");
            return Math.PI * Math.Pow(Radius, 2);          
        }
    }
}
