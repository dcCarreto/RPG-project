namespace WeaponsMain.Weapons;

public class HeavyCrossbow : Weapons
{
    Range = "Ranged";
    WeaponProficiency = "Martial";
    Name = "Heavy Crossbow";
    CoinType = "GP"
    Price = 50;
    Damage = "1d10";
    DamageType = "Piercing";
    Weight = 18;
    protected string Properties1 = "Ammunition"; // range 100/400
    protected string Properties2 = "Heavy";
    protected string Properties3 = "Loading";
    protected string Properties4 = "Two-handed";
}