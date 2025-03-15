using ClassLibrary;
using System;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterDirector director = new CharacterDirector();

            HeroBuilder heroBuilder = new HeroBuilder();
            Character edith = director.BuildEdith(heroBuilder);
            Console.WriteLine("♥Edith♥");
            Console.WriteLine("-------");
            edith.DisplayInfo();

            Console.WriteLine("\n---------------------\n");

            EnemyBuilder enemyBuilder = new EnemyBuilder();
            Character bane = director.BuildDarius(enemyBuilder);
            Console.WriteLine("♠Darius♠");
            Console.WriteLine("-------");
            bane.DisplayInfo();

            Console.ReadLine();
        }
    }
}
