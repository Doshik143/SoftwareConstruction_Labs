namespace ClassLibrary
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHeight(double height);
        ICharacterBuilder SetBuild(string build);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder AddToInventory(string item);
        ICharacterBuilder AddGoodDeed(string deed);
        ICharacterBuilder AddEvilDeed(string deed);
        Character Build();
    }
}