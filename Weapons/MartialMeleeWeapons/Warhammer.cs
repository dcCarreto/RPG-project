namespace Weapons;

public class Warhammer : Weapon
{
    public Warhammer()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Martial";
        Name = "Warhammer";
        CoinType = "GP";
        Price = 15;
        Damage = "1d8";
        DamageType = "Bludgeoning";
        Weight = 2;
        Properties1 = "Versatile"; // 1d10
        Properties1 = null;
        Properties3 = null;
        Properties4 = null;
    }   
    
}