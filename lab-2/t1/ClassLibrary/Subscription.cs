using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public abstract class Subscription
    {
        public decimal MonthlyFee { get; set; }
        public int MinimumPeriod { get; protected set; }
        public List<string> Channels { get; protected set; }

        public Subscription()
        {
            Channels = new List<string>();
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nMonthly Fee: {MonthlyFee}");
            Console.WriteLine($"Minimum Period: {MinimumPeriod} months");
            Console.WriteLine("\nChannels:");
            foreach (var channel in Channels)
            {
                Console.WriteLine($"- {channel}");
            }
        }
    }
}