#nullable enable

namespace DesignPatterns.Mediator
{
    class Aircraft
    {
        public string Name { get; }
        public Runway? CurrentRunway { get; set; }
        public bool IsTakingOff { get; set; }
        public ICommandCentre? CommandCentre { get; set; }

        public Aircraft(string name)
        {
            this.Name = name;
        }

        public void Land()
        {
            CommandCentre?.Notify(this, "Land");
        }

        public void TakeOff()
        {
            CommandCentre?.Notify(this, "TakeOff");
        }
    }
}