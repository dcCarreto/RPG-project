namespace Armors;

public class Hide : Armor
{
    public Hide()
    {
        ArmorType = "Medium Armor";
        ArmorClass = 12;
        Name = "Hide";
        CoinType = "GP";
        Price = 10;
        Requirements = string.Empty;
        Stealth = string.Empty;
        Weight = 13;
    }
}