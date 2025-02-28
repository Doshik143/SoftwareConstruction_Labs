using System;

namespace ClassLibrary
{
    public class Warehouse
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public Money Price { get; set; }
        public int Quantity { get; set; }
        public DateTime LastDeliveryDate { get; set; }
        public ProductCategory Category { get; set; }

        public Warehouse(string name, string unit, Money price, int quantity, DateTime lastDeliveryDate, ProductCategory category)
        {
            Name = name;
            Unit = unit;
            Price = price;
            Quantity = quantity;
            LastDeliveryDate = lastDeliveryDate;
            Category = category;
        }
    }
}