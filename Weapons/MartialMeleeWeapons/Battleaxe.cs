public class Battleaxe : Weapons
{
    public Battleaxe()
    {
        Range = "Melee";
        WeaponProficiency = "Martial";
        Name = "Battleaxe";
        CoinType = "GP";
        Price = 10;
        Damage = "1d8";
        DamageType = "Slashing";
        Weight = 4;
        Properties1 = "Versatile"; // 1d10 
        Properties2 = string.Empty;
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}