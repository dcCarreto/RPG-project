namespace Armors;

public class Leather : Armor
{
    public Leather()
    {
        ArmorType = "Light Armor";
        ArmorClass = 11;
        Name = "Leather";
        CoinType = "GP";
        Price = 10;
        Requirements = string.Empty;
        Stealth = string.Empty;
        Weight = 10;
    }
}