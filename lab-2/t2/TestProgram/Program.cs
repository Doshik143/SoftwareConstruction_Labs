using ClassLibrary;
using System;

namespace TestProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("↓Choose a brand↓\n");
            Console.WriteLine("1. IProne");
            Console.WriteLine("2. Kiaomi");
            Console.WriteLine("3. Balaxy");
            Console.WriteLine("-------");
            Console.Write("→ ");
            int brandChoice = int.Parse(Console.ReadLine());

            IDeviceFactory factory;

            switch (brandChoice)
            {
                case 1:
                    factory = new IProneFactory();
                    break;
                case 2:
                    factory = new KiaomiFactory();
                    break;
                case 3:
                    factory = new BalaxyFactory();
                    break;
                default:
                    throw new ArgumentException("Невірний вибір бренду");
            }
            Console.WriteLine("-------→Devices←-------");
            Console.WriteLine(factory.CreateLaptop().GetInfo());
            Console.WriteLine(factory.CreateNetbook().GetInfo());
            Console.WriteLine(factory.CreateEBook().GetInfo());
            Console.WriteLine(factory.CreateSmartphone().GetInfo());

            Console.ReadLine();
        }
    }
}