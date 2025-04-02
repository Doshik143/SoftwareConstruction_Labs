namespace ClassLibrary
{
    public class SwordDecorator : HeroDecorator
    {
        public SwordDecorator(Hero hero) : base(hero) { }

        public override string GetDescription() => $"{base.GetDescription()} With Sword";
        public override int GetAttack() => base.GetAttack() + 60;
    }
}