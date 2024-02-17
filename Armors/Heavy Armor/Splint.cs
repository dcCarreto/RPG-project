namespace ArmorMain.Armor;

public class Splint : Armor
{
    Type = "Heavy Armor";
    ArmorClass = 17;
    Name = "Splint";
    CoinType = "GP";
    Price = 200;
    Requirements = ["Strength", 15];
    Stealth = "Disadvantage";
    Weight = 60;
}