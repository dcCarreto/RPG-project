public class LightCrossbow : Weapons
{
    public LightCrossbow()
    {
        Range = "Ranged";
        WeaponProficiency = "Simple";
        Name = "Light Crossbow";
        CoinType = "GP";
        Price = 25;
        Damage = "1d8";
        DamageType = "Piercing";
        Weight = 5;
        Properties1 = "Ammunition"; // range 80/320
        Properties2 = "Loading";
        Properties3 = "Two-handed";
        Properties4 = string.Empty;
    }
}