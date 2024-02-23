namespace Weapons;

public class Battleaxe : Weapon
{
    public Battleaxe()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Battleaxe";
        CoinType = "GP";
        Price = 10;
        Damage = "1d8";
        DamageType = "Slashing";
        Weight = 4;
        Properties1 = "Versatile"; // 1d10 
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}