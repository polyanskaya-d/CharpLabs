using System;
using GeometryLibrary;

namespace GeometryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо точки
            Point A = new Point(0, 0, "A");
            Point B = new Point(4, 0, "B");
            Point C = new Point(4, 3, "C");
            Point D = new Point(0, 3, "D");

            // Створюємо трикутник
            Figure triangle = new Figure(A, B, C);
            triangle.PerimeterCalculator();

            // Створюємо чотирикутник
            Figure quadrilateral = new Figure(A, B, C, D);
            quadrilateral.PerimeterCalculator();
        }
    }
}
