namespace Weapons;

public class Scimitar : Weapon
{
    public Scimitar()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Scimitar";
        CoinType = "GP";
        Price = 25;
        Damage = "1d6";
        DamageType = "Slashing";
        Weight = 3;
        Properties1 = "Finesse";
        Properties2 = "Light";
        Properties3 = null;
        Properties4 = null;
    }
}