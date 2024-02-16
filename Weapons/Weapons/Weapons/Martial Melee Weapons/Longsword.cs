namespace WeaponsMain.Weapons;

public class Longsword : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Martial";
    Name = "Longsword";
    CoinType = "GP"
    Price = 15;
    Damage = "1d8";
    DamageType = "Slashing";
    Weight = 3;
    protected string Properties1 = "Versatile"; // 1d10
}