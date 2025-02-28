using System;

namespace ClassLibrary
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }
        public ProductCategory Category { get; set; }

        public Product(string name, Money price, ProductCategory category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public void ReducePrice(int amount)
        {
            Price.Dollars -= amount;
        }
    }
}