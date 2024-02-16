namespace WeaponsMain.Weapons;

public class Maul : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Martial";
    Name = "Maul";
    CoinType = "GP"
    Price = 10;
    Damage = "2d6";
    DamageType = "Bludgeoning";
    Weight = 10;
    protected string Properties1 = "Heavy";  // 1d10
    protected string Properties2 = "Two-handed";
}