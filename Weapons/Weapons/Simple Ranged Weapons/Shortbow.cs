namespace WeaponsMain.Weapons;

public class Shortbow : Weapons
{
    Range = "Ranged";
    WeaponProficiency = "Simple";
    Name = "Shortbow";
    CoinType = "GP"
    Price = 25;
    Damage = "1d6";
    DamageType = "Piercing";
    Weight = 2;
    protected string Properties1 = "Ammunition"; // range 80/320 
    protected string Properties2 = "Two-handed";
}