namespace WeaponsMain.Weapons;

public class LightHammer : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Simple";
    Name = "Light Hammer";
    CoinType = "GP"
    Price = 2;
    Damage = "1d6";
    DamageType = "Bludgeoning";
    Weight = 4;
    protected string Properties1 = "Light";
    protected string Properties2 = "Thrown"; // range 20/60
}