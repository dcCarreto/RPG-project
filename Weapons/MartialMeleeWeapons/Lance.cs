namespace Weapons;

public class Lance : Weapon
{
    public Lance()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Lance";
        CoinType = "GP";
        Price = 10;
        Damage = "1d12";
        DamageType = "Piercing";
        Weight = 6;
        Properties1 = "Reach";
        Properties2 = "Special";
        Properties3 = null;
        Properties4 = null;
    }
}