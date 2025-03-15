namespace ClassLibrary
{
    public class CharacterDirector
    {
        public Character BuildEdith(ICharacterBuilder builder)
        {
            return builder
                .SetName("Edith")
                .SetHeight(170)
                .SetBuild("Athletic")
                .SetHairColor("Yellow")
                .SetEyeColor("Blue")
                .SetClothing("Armor")
                .AddToInventory("Lightning")
                .AddToInventory("Shield")
                .AddGoodDeed("Protected the Land of Dawn")
                .Build();
        }

        public Character BuildDarius(ICharacterBuilder builder)
        {
            return builder
                .SetName("Darius")
                .SetHeight(195)
                .SetBuild("Muscular")
                .SetHairColor("White")
                .SetEyeColor("Black")
                .SetClothing("Heavy Armor")
                .AddToInventory("Blade")
                .AddToInventory("Shield")
                .AddEvilDeed("Conquered multiple kingdoms")
                .Build();
        }
    }
}