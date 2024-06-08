using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Остання цифра студента у списку групи
        int lastDigit = 0; // У вашому випадку це 0

        // Довжина масиву X
        int arrayLength = 10 + lastDigit;

        // Створюємо масив довжиною arrayLength
        int[] array = new int[arrayLength];

        // Заповнюємо масив випадковими значеннями в діапазоні [0, 100]
        Random random = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = random.Next(0, 101); // Заповнюємо значеннями від 0 до 100
        }

        // Виводимо масив
        Console.WriteLine("Масив:");
        Console.WriteLine(string.Join(", ", array));

        // Знаходимо мінімальне та максимальне значення
        int min = array.Min();
        int max = array.Max();

        // Виводимо мінімальне та максимальне значення
        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
    }
}
