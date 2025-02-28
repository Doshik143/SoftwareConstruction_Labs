using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class Reporting
    {
        private List<Warehouse> _warehouseItems = new List<Warehouse>();

        public void RegisterIncomingProduct(Warehouse product)
        {
            _warehouseItems.Add(product);
            Console.WriteLine($"Product {product.Name} added to the warehouse.");
            Console.WriteLine("---------------------");
        }

        public void ShipProduct(string productName)
        {
            var product = _warehouseItems.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                _warehouseItems.Remove(product);
                Console.WriteLine($"Product {productName} shipped from the warehouse.");
                Console.WriteLine("---------------------");
            }
        }

        public void InventoryReport()
        {
            Console.WriteLine("Inventory Report:\n");
            foreach (var item in _warehouseItems)
            {
                Console.WriteLine($"{item.Name} - {item.Quantity} {item.Unit}\nCategory: {item.Category}\nPrice per unit: {item.Price.Dollars}.{item.Price.Cents:00}\nLast Delivery: {item.LastDeliveryDate.ToShortDateString()}\n------");
            }
        }
    }
}