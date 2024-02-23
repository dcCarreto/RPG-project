namespace Weapons;

public class Handaxe : Weapon
{
    public Handaxe()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Simple";
        Name = "Handaxe";
        CoinType = "GP";
        Price = 5;
        Damage = "1d6";
        DamageType = "Slashing";
        Weight = 2;
        Properties1 = "Light";
        Properties2 = "Thrown"; // range 20/60
        Properties3 = null;
        Properties4 = null;
    }
}