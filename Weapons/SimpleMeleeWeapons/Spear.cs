namespace Weapons;

public class Spear : Weapon
{
    public Spear()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Simple";
        Name = "Spear";
        CoinType = "GP";
        Price = 1;
        Damage = "1d6";
        DamageType = "Piercing";
        Weight = 3;
        Properties1 = "Thrown"; // range 20/60
        Properties2 = "Versatile"; // 1d8
        Properties2 = null;
        Properties2 = null;
    }
}
    