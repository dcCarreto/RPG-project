namespace WeaponsMain.Weapons;

public class Whip : Weapons
{
    Range = "Melee";
    WeaponProficiency = "Martial";
    Name = "Whip";
    CoinType = "GP"
    Price = 2;
    Damage = "1d4";
    DamageType = "Slashing";
    Weight = 3;
    protected string Properties1 = "Finesse";
    protected string Properties2 = "Reach";
}