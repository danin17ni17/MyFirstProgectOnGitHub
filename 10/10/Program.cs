using System;
using System.Windows.Forms;
using System.Reflection;


namespace _10
{
   public class Program
    {
        public static void PrintAllAssemblies()
        {
            AppDomain ad = AppDomain.CurrentDomain;
            Assembly[] loadedAssemblies = ad.GetAssemblies();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Here are the assemblies loaded in this appdomain\n");

            foreach (Assembly a in loadedAssemblies)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(a.FullName);
                Console.ResetColor();
            }
        }
       public static void Main(string[] args)
       {
           MessageBox.Show("Loaded System.Windows.Forms.dll");
           PrintAllAssemblies();
           Console.ReadLine();
        }
    }
}
