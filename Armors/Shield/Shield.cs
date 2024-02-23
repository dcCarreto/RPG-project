namespace Armors;

public class Shield : Armor
{
    public Shield()
    {
        ArmorType = "Shield";
        ArmorClass = +2;
        Name = "Shield";
        CoinType = "GP";
        Price = 10;
        Requirements = string.Empty;
        Stealth = string.Empty;
        Weight = 6;
    }
}