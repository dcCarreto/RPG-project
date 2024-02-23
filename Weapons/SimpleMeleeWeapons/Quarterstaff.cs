namespace Weapons;

public class Quarterstaff : Weapon
{
    public Quarterstaff()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Simple";
        Name = "Quarterstaff";
        CoinType = "SP";
        Price = 2;
        Damage = "1d6";
        DamageType = "Bludgeoing";
        Weight = 4;
        Properties1 = "Versatile"; // 1d8
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}