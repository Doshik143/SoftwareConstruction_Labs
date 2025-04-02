namespace ClassLibrary
{
    public class Paladin : Hero
    {
        public Paladin(string name)
        {
            Name = name;
        }

        public override string GetDescription() => $"Paladin {Name}";
        public override int GetAttack() => 111;
        public override int GetDefense() => 36;
        public override int GetHealth() => 2450;
    }
}