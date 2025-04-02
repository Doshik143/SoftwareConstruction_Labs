namespace ClassLibrary
{
    public class Mage : Hero
    {
        public Mage(string name)
        {
            Name = name;
        }

        public override string GetDescription() => $"Mage {Name}";
        public override int GetAttack() => 115;
        public override int GetDefense() => 30;
        public override int GetHealth() => 2621;

    }
}