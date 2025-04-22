namespace DesignPatterns.Mediator
{
    internal interface ICommandCentre
    {
        void Notify(Aircraft aircraft, string eventType);
        void RegisterRunway(Runway runway);
        void RegisterAircraft(Aircraft aircraft);
    }
}