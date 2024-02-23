namespace Weapons;

public class Greataxe : Weapon
{
    public Greataxe()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Greataxe";
        CoinType = "GP";
        Price = 30;
        Damage = "1d12";
        DamageType = "Slashing";
        Weight = 7;
        Properties1 = "Heavy";
        Properties2 = "Two-handed";
        Properties3 = null;
        Properties4 = null;
    }
}