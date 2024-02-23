namespace Weapons;

public class Mace : Weapon
{
    public Mace()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Simple";
        Name = "Mace";
        CoinType = "GP";
        Price = 5;
        Damage = "1d6";
        DamageType = "Bludgeoning";
        Weight = 4;
        Properties1 = null;
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}