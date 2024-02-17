namespace ArmorMain.Armor;

public class ChainMail : Armor
{
    Type = "Heavy Armor";
    ArmorClass = 16;
    Name = "Chain Mail";
    CoinType = "GP";
    Price = 75;
    Requirements = ["Strength", 13];
    Stealth = "Disadvantage";
    Weight = 55;
}