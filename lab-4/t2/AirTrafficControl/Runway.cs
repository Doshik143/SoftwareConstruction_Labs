#nullable enable
using System;

namespace DesignPatterns.Mediator
{
    class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public Aircraft? IsBusyWithAircraft { get; set; }
        public ICommandCentre? CommandCentre { get; set; }

        public bool CheckIsActive()
        {
            return IsBusyWithAircraft?.IsTakingOff ?? false;
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }
}