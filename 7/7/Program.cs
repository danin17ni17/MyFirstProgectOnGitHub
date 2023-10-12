using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите первое число для сложения: ");
            Console.ResetColor();
            string s = Console.ReadLine();
            double a = Convert.ToDouble(s);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите второе число для сложения: ");
            Console.ResetColor();
            string s2 = Console.ReadLine();
            double b = Convert.ToDouble(s2);

            double c = a + b;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Сумма данных чисел: ");
            Console.ResetColor();
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
