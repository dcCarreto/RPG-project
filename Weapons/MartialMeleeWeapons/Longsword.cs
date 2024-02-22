public class Longsword : Weapons
{
    public Longsword()
    {
        Range = "Melee";
        WeaponProficiency = "Martial";
        Name = "Longsword";
        CoinType = "GP";
        Price = 15;
        Damage = "1d8";
        DamageType = "Slashing";
        Weight = 3;
        Properties1 = "Versatile"; // 1d10
        Properties2 = string.Empty;
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }

}