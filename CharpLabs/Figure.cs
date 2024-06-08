using System;

namespace GeometryLibrary
{
    public class Figure
    {
        private Point[] points;

        // Конструктор для 3-х точок
        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 };
        }

        // Конструктор для 4-х точок
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 };
        }

        // Конструктор для 5-ти точок
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
        }

        // Метод для розрахунку довжини сторони
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        // Метод для розрахунку периметру
        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                Point current = points[i];
                Point next = points[(i + 1) % points.Length];
                perimeter += LengthSide(current, next);
            }

            Console.WriteLine($"The perimeter of the {Name} is {perimeter}");
        }

        // Властивість для отримання назви фігури
        public string Name
        {
            get
            {
                switch (points.Length)
                {
                    case 3: return "Triangle";
                    case 4: return "Quadrilateral";
                    case 5: return "Pentagon";
                    default: return "Polygon";
                }
            }
        }
    }
}
