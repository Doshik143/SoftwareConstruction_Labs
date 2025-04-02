namespace ClassLibrary
{
    public class ShieldDecorator : HeroDecorator
    {
        public ShieldDecorator(Hero hero) : base(hero) { }

        public override string GetDescription() => $"{base.GetDescription()} With Shield";
        public override int GetDefense() => base.GetDefense() + 55;
    }
}