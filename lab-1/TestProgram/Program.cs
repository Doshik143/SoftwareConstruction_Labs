using System;
using ClassLibrary;

namespace TestProgram
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Creation of objects
            Money price = new Money(10, 50);
            Product product = new Product("Apple", price, ProductCategory.Food);
            Warehouse warehouse = new Warehouse("Apple", "kg", price, 100, DateTime.Now, ProductCategory.Food);
            Warehouse laptop = new Warehouse("Laptop", "pcs", new Money(1500, 0), 10, DateTime.Now, ProductCategory.Electronics);
            Warehouse tShirt = new Warehouse("T-Shirt", "pcs", new Money(20, 0), 50, DateTime.Now, ProductCategory.Clothing);
            Reporting reporting = new Reporting();

            Console.WriteLine("---------------------");

            //Registration of goods receipt
            reporting.RegisterIncomingProduct(warehouse);

            //Output of the inventory report
            reporting.InventoryReport();

            //Reduction in the price of the product
            product.ReducePrice(2);
            Console.WriteLine("---------------------");
            Console.Write($"New price for {product.Name}: ");
            product.Price.DisplayAmount();

            Console.WriteLine("---------------------");

            //Shipment of goods
            reporting.ShipProduct("Apple");
            reporting.RegisterIncomingProduct(laptop);
            reporting.RegisterIncomingProduct(tShirt);

            //Output of the updated inventory report
            reporting.InventoryReport();

            Console.WriteLine("\n\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}