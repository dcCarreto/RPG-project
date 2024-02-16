namespace WeaponsMain.Weapons;

public class LightCrossbow : Weapons
{
    Range = "Ranged";
    WeaponProficiency = "Simple";
    Name = "Light Crossbow";
    CoinType = "GP"
    Price = 25;
    Damage = "1d8";
    DamageType = "Piercing";
    Weight = 5;
    protected string Properties1 = "Ammunition"; // range 80/320
    protected string Properties2 = "Loading";
    protected string Properties3 = "Two-handed";
}