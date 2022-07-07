using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Triangle: Figure
    {
        double FirstSide { get; }
        double SecondSide { get; }
        double ThirdSide { get; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public override double Square()
        {
            if (FirstSide <= 0 && SecondSide <= 0 && ThirdSide <= 0) 
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной и равняться нулю");

            if (FirstSide + SecondSide > ThirdSide && SecondSide + ThirdSide > FirstSide && FirstSide + ThirdSide > SecondSide)
            {
                double p = (FirstSide + SecondSide + ThirdSide) / 2;
                return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
            }
            else throw new ArgumentOutOfRangeException("Треугольника не существует");
        }

        public bool CheckRightTriangle()
        {
            if (Math.Pow(ThirdSide, 2) == Math.Pow(SecondSide, 2) + Math.Pow(FirstSide, 2)) return true;
            else return false;
        }
    }
}
