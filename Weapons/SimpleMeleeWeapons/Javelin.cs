namespace Weapons;

public class Javelin : Weapon
{
    public Javelin()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Simple";
        Name = "Javelin";
        CoinType = "SP";
        Price = 5;
        Damage = "1d6";
        DamageType = "Piercing";
        Weight = 2;
        Properties1 = "Thrown"; // range 30/120
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}