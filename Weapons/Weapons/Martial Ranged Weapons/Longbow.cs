namespace WeaponsMain.Weapons;

public class Longbow : Weapons
{
    Range = "Ranged";
    WeaponProficiency = "Martial";
    Name = "Longbow";
    CoinType = "GP"
    Price = 50;
    Damage = "1d8";
    DamageType = "Piercing";
    Weight = 2;
    protected string Properties1 = "Ammunition"; // range 150/600
    protected string Properties2 = "Heavy";
    protected string Properties3 = "Two-handed";
}