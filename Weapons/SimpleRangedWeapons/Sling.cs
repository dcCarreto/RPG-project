namespace Weapons;

public class Sling : Weapon
{
    public Sling()
    {
        WeaponRange = "Ranged";
        WeaponProficiency = "Simple";
        Name = "Sling";
        CoinType = "SP";
        Price = 1;
        Damage = "1d4";
        DamageType = "Bludgeoning";
        Weight = 0; // TODO: definir como null.
        Properties1 = "Ammunition"; // range 30/120 
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}