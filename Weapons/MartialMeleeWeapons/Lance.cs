public class Lance : Weapons
{
    public Lance()
    {
        Range = "Melee";
        WeaponProficiency = "Martial";
        Name = "Lance";
        CoinType = "GP";
        Price = 10;
        Damage = "1d12";
        DamageType = "Piercing";
        Weight = 6;
        Properties1 = "Reach";
        Properties2 = "Special";
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}