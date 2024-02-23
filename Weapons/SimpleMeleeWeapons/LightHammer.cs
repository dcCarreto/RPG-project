namespace Weapons;

public class LightHammer : Weapon
{
    public LightHammer()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Simple";
        Name = "Light Hammer";
        CoinType = "GP";
        Price = 2;
        Damage = "1d6";
        DamageType = "Bludgeoning";
        Weight = 4;
        Properties1 = "Light";
        Properties2 = "Thrown"; // range 20/60
        Properties3 = null;
        Properties4 = null;
    }
}