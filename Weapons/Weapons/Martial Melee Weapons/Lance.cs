namespace WeaponsMain.Weapons;

public class Lance : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Martial";
    Name = "Lance";
    CoinType = "GP"
    Price = 10;
    Damage = "1d12";
    DamageType = "Piercing";
    Weight = 6;
    protected string Properties1 = "Reach";
    protected string Properties2 = "Special";
}