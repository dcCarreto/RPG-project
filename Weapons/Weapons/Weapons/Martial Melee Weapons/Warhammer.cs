namespace WeaponsMain.Weapons;

public class Warhammer : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Martial";
    Name = "Warhammer";
    CoinType = "GP"
    Price = 15;
    Damage = "1d8";
    DamageType = "Bludgeoning";
    Weight = 2;
    protected string Properties1 = "Versatile"; // 1d10
}