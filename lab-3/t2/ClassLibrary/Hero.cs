namespace ClassLibrary
{
    public abstract class Hero
    {
        public string Name { get; protected set; }
        public abstract string GetDescription();
        public abstract int GetAttack();
        public abstract int GetDefense();
        public abstract int GetHealth();
    }
}