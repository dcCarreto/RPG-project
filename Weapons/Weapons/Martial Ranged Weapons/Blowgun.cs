namespace WeaponsMain.Weapons;

public class Blowgun : Weapons
{
    Range = "Ranged";
    WeaponProficiency = "Martial";
    Name = "Blowgun";
    CoinType = "GP"
    Price = 10;
    Damage = "1"; // TODO: mudar varType?
    DamageType = "Piercing";
    Weight = 1;
    protected string Properties1 = "Ammunition"; // range 25/100
    protected string Properties2 = "Loading";
}