namespace ArmorMain.Armor;

public class Plate : Armor
{
    Type = "Heavy Armor";
    ArmorClass = 18;
    Name = "Plate";
    CoinType = "GP";
    Price = 1500;
    Requirements = ["Strength", 15];
    Stealth = "Disadvantage";
    Weight = 65;
}