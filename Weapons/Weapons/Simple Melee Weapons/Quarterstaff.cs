namespace WeaponsMain.Weapons;

public class Quarterstaff : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Simple";
    Name = "Quarterstaff";
    CoinType = "SP"
    Price = 2;
    Damage = "1d6";
    DamageType = "Bludgeoing";
    Weight = 4;
    protected string Properties1 = "Versatile"; // 1d8
}