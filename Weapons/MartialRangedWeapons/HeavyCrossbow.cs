public class HeavyCrossbow : Weapons
{
    public HeavyCrossbow()
    {
        Range = "Ranged";
        WeaponProficiency = "Martial";
        Name = "Heavy Crossbow";
        CoinType = "GP";
        Price = 50;
        Damage = "1d10";
        DamageType = "Piercing";
        Weight = 18;
        Properties1 = "Ammunition"; // range 100/400
        Properties2 = "Heavy";
        Properties3 = "Loading";
        Properties4 = "Two-handed";
    }
}