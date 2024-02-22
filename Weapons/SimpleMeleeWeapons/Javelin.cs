public class Javelin : Weapons
{
    public Javelin()
    {
        Range = "Melee";
        WeaponProficiency = "Simple";
        Name = "Javelin";
        CoinType = "SP";
        Price = 5;
        Damage = "1d6";
        DamageType = "Piercing";
        Weight = 2;
        Properties1 = "Thrown"; // range 30/120
        Properties2 = string.Empty;
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}