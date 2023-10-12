using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");

            string s;
            s = Console.ReadLine();
            Console.WriteLine("Hello, {0}", s);
            Console.Write("Enter your age: ");

            s = Console.ReadLine();
            Console.WriteLine("You are {0} years old\n", s);
            Console.Write("Nice to meet you!\nWelcome to C#");
            Console.ReadLine();
        }
    }
}