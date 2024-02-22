public class Pike : Weapons
{
    public Pike()
    {
        Range = "Melee";
        WeaponProficiency = "Martial";
        Name = "Pike";
        CoinType = "GP";
        Price = 5;
        Damage = "1d10";
        DamageType = "Piercing";
        Weight = 18;
        Properties1 = "Heavy";
        Properties2 = "Reach";
        Properties2 = "Two-handed";
        Properties3 = string.Empty;
    }
}