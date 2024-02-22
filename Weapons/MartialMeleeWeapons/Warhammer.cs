public class Warhammer : Weapons
{
    public Warhammer()
    {
        Range = "Melee";
        WeaponProficiency = "Martial";
        Name = "Warhammer";
        CoinType = "GP";
        Price = 15;
        Damage = "1d8";
        DamageType = "Bludgeoning";
        Weight = 2;
        Properties1 = "Versatile"; // 1d10
        Properties1 = string.Empty;
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }   
    
}