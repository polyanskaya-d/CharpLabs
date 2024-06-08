using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Довжина масиву X
        int arrayLength = 10; // Оскільки остання цифра студента є 0, довжина масиву дорівнює 10

        // Створюємо масив X довжиною 10
        int[] arrayX = new int[arrayLength];

        // Заповнюємо масив випадковими значеннями (в діапазоні [-50, 50])
        Random random = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            arrayX[i] = random.Next(-50, 51); // Заповнюємо значеннями від -50 до 50
        }

        // Виводимо масив X
        Console.WriteLine("Масив X:");
        Console.WriteLine(string.Join(", ", arrayX));

        // Запитуємо у користувача значення M
        Console.Write("Введіть значення M: ");
        if (!int.TryParse(Console.ReadLine(), out int M))
        {
            Console.WriteLine("Некоректне введення. Введіть ціле число для M.");
            return;
        }

        // Формуємо масив Y, який містить тільки елементи з X, що більше M за модулем
        List<int> listY = new List<int>();
        foreach (int element in arrayX)
        {
            if (Math.Abs(element) > M)
            {
                listY.Add(element);
            }
        }

        // Перетворюємо список Y в масив
        int[] arrayY = listY.ToArray();

        // Виводимо значення M
        Console.WriteLine($"Значення M: {M}");

        // Виводимо масив Y
        Console.WriteLine("Масив Y:");
        Console.WriteLine(string.Join(", ", arrayY));
    }
}
