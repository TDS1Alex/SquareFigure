using System;
using SquareFigure.Figures;

namespace SquareFigure.UI
{
    class ChoiceFigure : IChoiceFigure
    {
        private readonly ICircle _circle;
        private readonly ITriangle _triangle;

        public ChoiceFigure(ICircle circle, ITriangle triangle)
        {
            _circle = circle;
            _triangle = triangle;
        }

        public void Start()
        {
            Console.WriteLine("Выберите фигуру: \n1.Круг \n2.Треугольник");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    _circle.GetRadius();
                    break;

                case "2":
                    _triangle.GetSide();
                    break;
            }

            Start();
        }
    }
}
