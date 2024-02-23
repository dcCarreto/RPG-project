namespace Weapons;

public class Longsword : Weapon
{
    public Longsword()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Longsword";
        CoinType = "GP";
        Price = 15;
        Damage = "1d8";
        DamageType = "Slashing";
        Weight = 3;
        Properties1 = "Versatile"; // 1d10
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }

}