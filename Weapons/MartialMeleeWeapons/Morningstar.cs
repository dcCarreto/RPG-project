namespace Weapons;

public class Morningstar : Weapon
{
    public Morningstar()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Morningstar";
        CoinType = "GP";
        Price = 15;
        Damage = "1d8";
        DamageType = "Piercing";
        Weight = 4;
        Properties1 = null;
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}