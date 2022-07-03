using System;

namespace SquareFigure.Figures
{
    class Triangle : ITriangle
    {
        public void GetSide()
        {
            Console.WriteLine("Введите длину первой стороны:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину третьей стороны:");
            double c = Convert.ToDouble(Console.ReadLine());

            SquareTriangle(a,b,c);
        }

        public void SquareTriangle(double a, double b, double c)
        {
            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Треугольник существует");
                Console.WriteLine("-------");
            }
            else
            {
                Console.WriteLine("Треугольника не существует");
                Console.WriteLine("-------");
                return;
            }

            double p = (a + b + c) / 2;
            double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
            {
                Console.WriteLine("Треугольник прямоугольный");
                Console.WriteLine($"Его площадь равна со сторонами a = {a}, b = {b}, c = {c} равна {result}");
                Console.WriteLine("-------");
            }
            else
            {
                Console.WriteLine($"Площадь треугольника равна со сторонами a = {a}, b = {b}, c = {c} равна {result}");
                Console.WriteLine("-------");
            }
        }
    }
}
