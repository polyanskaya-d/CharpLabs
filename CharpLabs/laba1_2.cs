using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть три сторони трикутника:");

        // Зчитуємо три сторони трикутника
        if (!double.TryParse(Console.ReadLine(), out double side1) ||
            !double.TryParse(Console.ReadLine(), out double side2) ||
            !double.TryParse(Console.ReadLine(), out double side3))
        {
            Console.WriteLine("Некоректні вхідні дані. Введіть дійсні числа.");
            return;
        }

        // Перевірка дійсності трикутника
        if (!IsValidTriangle(side1, side2, side3))
        {
            Console.WriteLine("Ці сторони не утворюють дійсний трикутник.");
            return;
        }

        // Обчислення периметра та площі
        double perimeter = side1 + side2 + side3;
        double area = CalculateArea(side1, side2, side3);

        // Вивід результатів
        Console.WriteLine($"Периметр трикутника: {perimeter}");
        Console.WriteLine($"Площа трикутника: {area}");

        // Визначення виду трикутника
        string triangleType = DetermineTriangleType(side1, side2, side3);
        Console.WriteLine($"Вид трикутника: {triangleType}");
    }

    // Функція для перевірки дійсності трикутника
    static bool IsValidTriangle(double a, double b, double c)
    {
        return a > 0 && b > 0 && c > 0 &&
               a + b > c && a + c > b && b + c > a;
    }

    // Функція для обчислення площі трикутника (формула Герона)
    static double CalculateArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    // Функція для визначення типу трикутника
    static string DetermineTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Рівносторонній трикутник";
        }
        else if (a == b || b == c || c == a)
        {
            return "Рівнобедрений трикутник";
        }
        else
        {
            return "Різносторонній трикутник";
        }
    }
}
