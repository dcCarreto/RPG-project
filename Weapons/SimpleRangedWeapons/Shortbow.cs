public class Shortbow : Weapons
{
    public Shortbow()
    {
        Range = "Ranged";
        WeaponProficiency = "Simple";
        Name = "Shortbow";
        CoinType = "GP";
        Price = 25;
        Damage = "1d6";
        DamageType = "Piercing";
        Weight = 2;
        Properties1 = "Ammunition"; // range 80/320 
        Properties2 = "Two-handed";
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}