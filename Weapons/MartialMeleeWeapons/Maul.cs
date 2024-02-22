public class Maul : Weapons
{
    public Maul()
    {
        Range = "Melee";
        WeaponProficiency = "Martial";
        Name = "Maul";
        CoinType = "GP";
        Price = 10;
        Damage = "2d6";
        DamageType = "Bludgeoning";
        Weight = 10;
        Properties1 = "Heavy";  // 1d10
        Properties2 = "Two-handed";
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}