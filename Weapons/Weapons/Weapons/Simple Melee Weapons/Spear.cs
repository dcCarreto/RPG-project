namespace WeaponsMain.Weapons;

public class Spear : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Simple";
    Name = "Spear";
    CoinType = "GP"
    Price = 1;
    Damage = "1d6";
    DamageType = "Piercing";
    Weight = 3;
    protected string Properties1 = "Thrown"; // range 20/60
    protected string Properties2 = "Versatile"; // 1d8
}