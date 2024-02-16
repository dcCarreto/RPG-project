namespace WeaponsMain.Weapons;

public class Handaxe : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Simple";
    Name = "Handaxe";
    CoinType = "GP"
    Price = 5;
    Damage = "1d6";
    DamageType = "Slashing";
    Weight = 2;
    protected string Properties1 = "Light";
    protected string Properties2 = "Thrown"; // range 20/60
}