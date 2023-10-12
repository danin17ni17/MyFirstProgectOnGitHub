using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of .NET");
            Console.WriteLine("1 = C#\n2 = Managed C++ (Mc++)\n3 = VB.NET\n");
            Console.Write("Please select your implementation language: ");
            string s = Console.ReadLine();

            int n = int.Parse(s);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice! C# is all about managed code.");
                    break;

                case 2:
                    Console.WriteLine("Let me guess, maintaining a legacy system?");
                    break;

                case 3:
                    Console.WriteLine("VB.NET: It is not just for kids anymore...");
                    break;

                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;

            }
            Console.ReadLine();
            return 0;
        }
    }
}