namespace Weapons;

public class Greatclub : Weapon
{
    public Greatclub()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Simple";
        Name = "Greatclub";
        CoinType = "SP";
        Price = 2;
        Damage = "1d8";
        DamageType = "Bludgeoning";
        Weight = 10;
        Properties1 = "Two-handed";
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}