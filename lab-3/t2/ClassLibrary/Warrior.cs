namespace ClassLibrary
{
    public class Warrior : Hero
    {
        public Warrior(string name)
        {
            Name = name;
        }

        public override string GetDescription() => $"Warrior {Name}";
        public override int GetAttack() => 109;
        public override int GetDefense() => 37;
        public override int GetHealth() => 2623;
    }
}