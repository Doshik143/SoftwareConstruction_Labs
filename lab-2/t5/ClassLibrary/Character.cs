using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Character
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> GoodDeeds { get; set; } = new List<string>();
        public List<string> EvilDeeds { get; set; } = new List<string>();

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Build: {Build}");
            Console.WriteLine($"Hair Color: {HairColor}");
            Console.WriteLine($"Eye Color: {EyeColor}");
            Console.WriteLine($"Clothing: {Clothing}");
            Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
            Console.WriteLine("Good Deeds: " + string.Join(", ", GoodDeeds));
            Console.WriteLine("Evil Deeds: " + string.Join(", ", EvilDeeds));
        }
    }
}