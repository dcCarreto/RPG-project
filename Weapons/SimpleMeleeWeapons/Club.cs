namespace Weapons;

public class Club : Weapon
{
    public Club()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Simple";
        Name = "Club";
        CoinType = "SP";
        Price = 1;
        Damage = "1d4";
        DamageType = "Bludgeoning";
        Weight = 2;
        Properties1 = "Light";
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}