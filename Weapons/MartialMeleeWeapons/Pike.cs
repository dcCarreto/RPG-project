namespace Weapons;

public class Pike : Weapon
{
    public Pike()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Pike";
        CoinType = "GP";
        Price = 5;
        Damage = "1d10";
        DamageType = "Piercing";
        Weight = 18;
        Properties1 = "Heavy";
        Properties2 = "Reach";
        Properties2 = "Two-handed";
        Properties3 = null;
    }
}