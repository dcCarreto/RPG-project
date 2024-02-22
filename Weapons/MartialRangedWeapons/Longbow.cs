public class Longbow : Weapons
{
    public Longbow()
    {
        Range = "Ranged";
        WeaponProficiency = "Martial";
        Name = "Longbow";
        CoinType = "GP";
        Price = 50;
        Damage = "1d8";
        DamageType = "Piercing";
        Weight = 2;
        Properties1 = "Ammunition"; // range 150/600
        Properties2 = "Heavy";
        Properties3 = "Two-handed";
        Properties4 = string.Empty;
    }
}
    