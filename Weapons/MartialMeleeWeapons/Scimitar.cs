public class Scimitar : Weapons
{
    public Scimitar()
    {
        Range = "Melee";
        WeaponProficiency = "Martial";
        Name = "Scimitar";
        CoinType = "GP";
        Price = 25;
        Damage = "1d6";
        DamageType = "Slashing";
        Weight = 3;
        Properties1 = "Finesse";
        Properties2 = "Light";
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}