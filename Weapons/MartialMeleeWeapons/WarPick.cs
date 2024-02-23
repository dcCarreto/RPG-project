namespace Weapons;

public class WarPick : Weapon
{
    public WarPick()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "WarPick";
        CoinType = "GP";
        Price = 5;
        Damage = "1d8";
        DamageType = "Piercing";
        Weight = 2;
        Properties1 = null;
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}