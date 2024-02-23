namespace Weapons;

public class Sickle : Weapon
{ 
    public Sickle()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Simple";
        Name = "Sickle";
        CoinType = "GP";
        Price = 1;
        Damage = "1d4";
        DamageType = "Slashing";
        Weight = 4;
        Properties1 = "Light";
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }  
}