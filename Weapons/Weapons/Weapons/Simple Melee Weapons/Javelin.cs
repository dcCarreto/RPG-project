namespace WeaponsMain.Weapons;

public class Javelin : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Simple";
    Name = "Javelin";
    CoinType = "SP"
    Price = 5;
    Damage = "1d6";
    DamageType = "Piercing";
    Weight = 2;
    protected string Properties1 = "Thrown"; // range 30/120
}