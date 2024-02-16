namespace WeaponsMain.Weapons;

public class Dagger : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Simple";
    Name = "Dagger";
    CoinType = "GP"
    Price = 2;
    Damage = "1d4";
    DamageType = "Piercing";
    Weight = 1;
    protected string Properties1 = "Finesse";
    protected string Properties2 = "Light";
    protected string Properties3 = "Thrown"; // range 20/60
}