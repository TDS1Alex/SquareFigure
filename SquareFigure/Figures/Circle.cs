using System;

namespace SquareFigure.Figures
{
    class Circle: ICircle
    {
        public void GetRadius()
        {
            Console.WriteLine("Введите радиус круга");
            double radius = Convert.ToDouble(Console.ReadLine());
            
            SquareCircle(radius);
        }

        public void SquareCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь круга с радиусом {radius} равна {Math.Round(area, 2)}");
            Console.WriteLine("-------");
        }
    }
}
