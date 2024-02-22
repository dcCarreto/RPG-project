public class Sling : Weapons
{
    public Sling()
    {
        Range = "Ranged";
        WeaponProficiency = "Simple";
        Name = "Sling";
        CoinType = "SP";
        Price = 1;
        Damage = "1d4";
        DamageType = "Bludgeoning";
        Weight = 0; // TODO: definir como null.
        Properties1 = "Ammunition"; // range 30/120 
        Properties2 = string.Empty;
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}