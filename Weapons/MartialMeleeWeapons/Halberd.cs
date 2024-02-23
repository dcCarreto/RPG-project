namespace Weapons;

public class Halberd : Weapon
{
    public Halberd()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Halberd";
        CoinType = "GP";
        Price = 20;
        Damage = "1d10";
        DamageType = "Slashing";
        Weight = 6;
        Properties1 = "Heavy";
        Properties2 = "Reach";
        Properties3 = "Two-handed";
        Properties4 = null;
    }
}