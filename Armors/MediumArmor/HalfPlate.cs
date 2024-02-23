namespace Armors;

public class HalfPlate : Armor
{
    public HalfPlate()
    {
        ArmorType = "Medium Armor";
        ArmorClass = 15;
        Name = "HalfPlate";
        CoinType = "GP";
        Price = 750;
        Requirements = string.Empty;
        Stealth = "Disadvante";
        Weight = 40;
    }
}