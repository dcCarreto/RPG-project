namespace Weapons;

public class Flail : Weapon
{
    public Flail()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Flail";
        CoinType = "GP";
        Price = 10;
        Damage = "1d8";
        DamageType = "Bludgeoning";
        Weight = 2;
        Properties1 = null;
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}