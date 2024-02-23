namespace Weapons;

public class Shortbow : Weapon
{
    public Shortbow()
    {
        WeaponRange = "Ranged";
        WeaponProficiency = "Simple";
        Name = "Shortbow";
        CoinType = "GP";
        Price = 25;
        Damage = "1d6";
        DamageType = "Piercing";
        Weight = 2;
        Properties1 = "Ammunition"; // range 80/320 
        Properties2 = "Two-handed";
        Properties3 = null;
        Properties4 = null;
    }
}