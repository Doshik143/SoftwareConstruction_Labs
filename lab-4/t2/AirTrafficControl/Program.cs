using DesignPatterns.Mediator;
using System;

namespace AirTrafficControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreatingObjects
            var runway1 = new Runway();
            var runway2 = new Runway();
            var aircraft1 = new Aircraft("Boeing 737");
            var aircraft2 = new Aircraft("Airbus A320");
            var aircraft3 = new Aircraft("Boeing 747");
            //CreatingIntermediaryAndRegisteringObjects
            var commandCentre = new CommandCentre(new[] { runway1, runway2 },
                                              new[] { aircraft1, aircraft2, aircraft3 });
            //Testing
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\tAttempting to land aircrafts\n");
            aircraft1.Land();
            aircraft2.Land();
            aircraft3.Land(); //This Plane Will Not Be Able To Land Because All Runways Are Occupied

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("\tAttempting to take off\n");
            aircraft1.TakeOff();
            aircraft3.Land(); //Now This Plane Can Land

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("\tAttempting to take off again\n");
            aircraft2.TakeOff();
            aircraft3.TakeOff();

            Console.ReadLine();
        }
    }
}
