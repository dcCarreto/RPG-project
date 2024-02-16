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
    Weight = 18;
    protected string Properties1 = "Ammunition"; // range 100/400
    protected string Properties2 = "Heavy";
    protected string Properties3 = "Two-handed";
}