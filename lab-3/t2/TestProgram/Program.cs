using ClassLibrary;
using System;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("↓Creating heroes and them equipping↓");
            //CreatingBasicHeroes
            Hero warrior = new Warrior("Freya");
            Hero mage = new Mage("Lunox");
            Hero paladin = new Paladin("Argus");
            //HeroEquipment
            Hero equippedWarrior = new ArmorDecorator(
                                    new SwordDecorator(
                                        new ShieldDecorator(warrior)));

            Hero equippedMage = new MagicAmuletDecorator(
                                   new SwordDecorator(mage));

            Hero equippedPaladin = new ArmorDecorator(
                                      new ShieldDecorator(
                                          new MagicAmuletDecorator(paladin)));

            //InformationAboutHero
            DisplayHeroInfo(warrior);
            DisplayHeroInfo(equippedWarrior);

            DisplayHeroInfo(mage);
            DisplayHeroInfo(equippedMage);

            DisplayHeroInfo(paladin);
            DisplayHeroInfo(equippedPaladin);

            Console.ReadLine();
        }

        static void DisplayHeroInfo(Hero hero)
        {
            Console.WriteLine("\n-------Information About Hero------");
            Console.WriteLine($"Description: {hero.GetDescription()}");
            Console.WriteLine($"Attack: {hero.GetAttack()}");
            Console.WriteLine($"Defense: {hero.GetDefense()}");
            Console.WriteLine($"Health: {hero.GetHealth()}");
        }
    }
}