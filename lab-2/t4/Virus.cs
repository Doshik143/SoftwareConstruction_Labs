using System;
using System.Collections.Generic;

namespace t4
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string species)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Species = species;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            Virus clone = new Virus(Weight, Age, Name, Species);

            foreach (var child in Children)
            {
                clone.AddChild((Virus)child.Clone());
            }

            return clone;
        }

        public void DisplayInfo(string indent = "")
        {
            Console.WriteLine($"{indent}Name: {Name}, Species: {Species}, Age: {Age}, Weight: {Weight}");
            foreach (var child in Children)
            {
                child.DisplayInfo(indent + "  ");
            }
        }
    }
}