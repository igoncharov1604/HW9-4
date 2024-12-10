using System;

class Program
{
    static void Main(string[] args)
    {
        // Масив із 10 елементів (додатні та від'ємні числа)
        int[] numbers = { -10, 25, -7, 12, 0, -3, 15, -8, 30, -1 };

        // Блоковий лямбда-вираз
        Func<int, bool> isPositive = s =>
        {
            if (s > 0)
                return true;
            else
                return false;
        };

        // Введення числа s з консолі
        Console.Write("Введіть число s: ");
        if (int.TryParse(Console.ReadLine(), out int s))
        {
            // Перевірка, чи число додатнє
            bool result = isPositive(s);

            // Вивід результату
            Console.WriteLine($"Число {s} є додатнім: {result}");
        }
        else
        {
            Console.WriteLine("Введено некоректне число.");
        }
    }
}
