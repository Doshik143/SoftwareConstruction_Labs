namespace ClassLibrary
{
    public class ArmorDecorator : HeroDecorator
    {
        public ArmorDecorator(Hero hero) : base(hero) { }

        public override string GetDescription() => $"{base.GetDescription()} In Armor";
        public override int GetDefense() => base.GetDefense() + 40;
        public override int GetHealth() => base.GetHealth() + 920;
    }
}