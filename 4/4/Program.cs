using System;

namespace _4
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Current OS: {0}", Environment.OSVersion);
            Console.WriteLine("Current Directory: {0}", Environment.CurrentDirectory);
            string[] drives = Environment.GetLogicalDrives();
            for (int i = 0; i < drives.Length; i++)
                Console.WriteLine("Drive {0} : {1}", i, drives[i]);
            Console.WriteLine("CurrentVersion of .NET: {0}", Environment.Version);
            Console.ReadLine();
            return 0;
        }
    }
}
