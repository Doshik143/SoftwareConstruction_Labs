namespace ClassLibrary
{
    public abstract class HeroDecorator : Hero
    {
        protected Hero _hero;

        protected HeroDecorator(Hero hero)
        {
            _hero = hero;
        }

        public override string GetDescription() => _hero.GetDescription();
        public override int GetAttack() => _hero.GetAttack();
        public override int GetDefense() => _hero.GetDefense();
        public override int GetHealth() => _hero.GetHealth();
    }
}