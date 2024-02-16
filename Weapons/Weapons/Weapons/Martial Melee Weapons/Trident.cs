namespace WeaponsMain.Weapons;

public class Trident : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Martial";
    Name = "Trident";
    CoinType = "GP"
    Price = 5;
    Damage = "1d6";
    DamageType = "Piercing";
    Weight = 4;
    protected string Properties1 = "Thrown"; // range 20/60
    protected string Properties2 = "Versatile"; // 1d8 
}