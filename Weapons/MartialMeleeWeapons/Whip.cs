public class Whip : Weapons
{

    public Whip()
    {
        Range = "Melee";
        WeaponProficiency = "Martial";
        Name = "Whip";
        CoinType = "GP";
        Price = 2;
        Damage = "1d4";
        DamageType = "Slashing";
        Weight = 3;
        Properties1 = "Finesse";
        Properties2 = "Reach";
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}