namespace ClassLibrary
{
    public class MagicAmuletDecorator : HeroDecorator
    {
        public MagicAmuletDecorator(Hero hero) : base(hero) { }

        public override string GetDescription() => $"{base.GetDescription()} With Magic Amulet";
        public override int GetAttack() => base.GetAttack() + 30;
        public override int GetDefense() => base.GetDefense() + 10;
        public override int GetHealth() => base.GetHealth() + 600;
    }
}