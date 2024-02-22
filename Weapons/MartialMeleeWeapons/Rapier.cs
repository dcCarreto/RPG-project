public class Rapier : Weapons
{
    public Rapier()
    {
        Range = "Melee";
        WeaponProficiency = "Martial";
        Name = "Rapier";
        CoinType = "GP";
        Price = 25;
        Damage = "1d8";
        DamageType = "Piercing";
        Weight = 2;
        Properties1 = "Finesse";
        Properties2 = string.Empty;
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}