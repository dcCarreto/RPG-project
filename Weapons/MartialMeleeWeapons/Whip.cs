namespace Weapons;

public class Whip : Weapon
{

    public Whip()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Whip";
        CoinType = "GP";
        Price = 2;
        Damage = "1d4";
        DamageType = "Slashing";
        Weight = 3;
        Properties1 = "Finesse";
        Properties2 = "Reach";
        Properties3 = null;
        Properties4 = null;
    }
}