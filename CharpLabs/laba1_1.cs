using System;

class Program
{
    static void Main()
    {
        // Задано три цілі числа
        Console.WriteLine("Введіть три цілі числа:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        // Визначаємо інтервал
        int lowerBound = 1;
        int upperBound = 40; // 10 + №, де № = 30

        Console.WriteLine($"Числа, що належать інтервалу [{lowerBound}, {upperBound}]:");

        // Перевірка кожного числа, чи воно знаходиться в інтервалі
        if (IsWithinRange(number1, lowerBound, upperBound))
        {
            Console.WriteLine(number1);
        }

        if (IsWithinRange(number2, lowerBound, upperBound))
        {
            Console.WriteLine(number2);
        }

        if (IsWithinRange(number3, lowerBound, upperBound))
        {
            Console.WriteLine(number3);
        }
    }

    // Функція для перевірки, чи число знаходиться в заданому інтервалі
    static bool IsWithinRange(int number, int lowerBound, int upperBound)
    {
        return number >= lowerBound && number <= upperBound;
    }
}
