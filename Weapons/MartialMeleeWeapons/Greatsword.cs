public class Greatsword : Weapons
{
    public Greatsword()
    {
        Range = "Melee";
        WeaponProficiency = "Martial";
        Name = "Greatsword";
        CoinType = "GP";
        Price = 50;
        Damage = "2d6";
        DamageType = "Slashing";
        Weight = 6;
        Properties1 = "Heavy";
        Properties2 = "Two-handed";
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}