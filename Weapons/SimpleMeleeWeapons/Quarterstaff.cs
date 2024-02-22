public class Quarterstaff : Weapons
{
    public Quarterstaff()
    {
        Range = "Melee";
        WeaponProficiency = "Simple";
        Name = "Quarterstaff";
        CoinType = "SP";
        Price = 2;
        Damage = "1d6";
        DamageType = "Bludgeoing";
        Weight = 4;
        Properties1 = "Versatile"; // 1d8
        Properties2 = string.Empty;
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}