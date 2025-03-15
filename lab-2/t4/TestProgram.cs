using System;

namespace t4
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Virus virus1 = new Virus(1.5, 10, "Virus1", "Coronavirus");
            Virus virus2 = new Virus(2.0, 8, "Virus2", "Influenza");
            Virus virus3 = new Virus(1.0, 5, "Virus3", "HIV");
            //virus1
            Virus child1 = new Virus(0.8, 5, "Child1", "Coronavirus");
            Virus child2 = new Virus(0.9, 6, "Child2", "Coronavirus");
            virus1.AddChild(child1);
            virus1.AddChild(child2);
            //virus2
            Virus child3 = new Virus(0.7, 4, "Child3", "Influenza");
            virus2.AddChild(child3);

            Console.WriteLine("↓Original Viruses↓");
            Console.WriteLine("---");
            virus1.DisplayInfo();
            Console.WriteLine("-------");
            virus2.DisplayInfo();
            Console.WriteLine("-------");
            virus3.DisplayInfo();

            Virus clonedVirus = (Virus)virus1.Clone();

            Console.WriteLine("\n------->Cloned Virus<-------");
            clonedVirus.DisplayInfo();

            Console.ReadLine();
        }
    }
}