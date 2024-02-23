namespace Weapons;

public class Maul : Weapon
{
    public Maul()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Maul";
        CoinType = "GP";
        Price = 10;
        Damage = "2d6";
        DamageType = "Bludgeoning";
        Weight = 10;
        Properties1 = "Heavy";  // 1d10
        Properties2 = "Two-handed";
        Properties3 = null;
        Properties4 = null;
    }
}