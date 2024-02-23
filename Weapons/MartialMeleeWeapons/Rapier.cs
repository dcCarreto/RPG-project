namespace Weapons;

public class Rapier : Weapon
{
    public Rapier()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Rapier";
        CoinType = "GP";
        Price = 25;
        Damage = "1d8";
        DamageType = "Piercing";
        Weight = 2;
        Properties1 = "Finesse";
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}