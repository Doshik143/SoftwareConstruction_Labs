using System;

namespace ClassLibrary
{
    public class Money
    {
        public int Dollars { get; set; }
        public int Cents { get; set; }

        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"{Dollars}.{Cents:00}");
        }
    }
}