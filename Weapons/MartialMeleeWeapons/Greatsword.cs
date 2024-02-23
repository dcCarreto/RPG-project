namespace Weapons;

public class Greatsword : Weapon
{
    public Greatsword()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Greatsword";
        CoinType = "GP";
        Price = 50;
        Damage = "2d6";
        DamageType = "Slashing";
        Weight = 6;
        Properties1 = "Heavy";
        Properties2 = "Two-handed";
        Properties3 = null;
        Properties4 = null;
    }
}