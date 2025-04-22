using System;
using System.Collections.Generic;

namespace DesignPatterns.Mediator
{
    class CommandCentre : ICommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            foreach (var runway in runways)
            {
                this.RegisterRunway(runway);
            }
            foreach (var aircraft in aircrafts)
            {
                this.RegisterAircraft(aircraft);
            }
        }

        public void RegisterRunway(Runway runway)
        {
            runway.CommandCentre = this;
            _runways.Add(runway);
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            aircraft.CommandCentre = this;
            _aircrafts.Add(aircraft);
        }

        public void Notify(Aircraft aircraft, string eventType)
        {
            if (eventType == "Land")
            {
                Console.WriteLine($"Checking runways for landing {aircraft.Name}...");

                foreach (var runway in _runways)
                {
                    if (runway.IsBusyWithAircraft == null)
                    {
                        Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway {runway.Id}.");
                        runway.IsBusyWithAircraft = aircraft;
                        runway.HighLightRed();
                        aircraft.CurrentRunway = runway;
                        return;
                    }
                }
                Console.WriteLine($"Could not land {aircraft.Name}, all runways are busy.");
            }
            else if (eventType == "TakeOff")
            {
                if (aircraft.CurrentRunway != null)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {aircraft.CurrentRunway.Id}.");
                    aircraft.CurrentRunway.IsBusyWithAircraft = null;
                    aircraft.CurrentRunway.HighLightGreen();
                    aircraft.CurrentRunway = null;
                    Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
                }
                else
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
                }
            }
        }
    }
}