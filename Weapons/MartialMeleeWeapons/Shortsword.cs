namespace Weapons;

public class Shortsword : Weapon
{
    public Shortsword()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Shortsword";
        CoinType = "GP";
        Price = 10;
        Damage = "1d6";
        DamageType = "Piercing";
        Weight = 2;
        Properties1 = "Finesse";
        Properties2 = "Light";
        Properties3 = null;
        Properties2 = null;
    }
}