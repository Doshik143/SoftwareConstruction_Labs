using ClassLibrary;
using System;

namespace TestProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tWelcome To Support System!");
            Console.Write("-------------------------------------------------\n");
            var supportSystem = new SupportSystem();
            supportSystem.Start();
            Console.ReadLine();
        }
    }
}