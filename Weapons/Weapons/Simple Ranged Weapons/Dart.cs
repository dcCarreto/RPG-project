namespace WeaponsMain.Weapons;

public class Dart : Weapons
{
    Range = "Ranged";
    WeaponProficiency = "Simple";
    Name = "Dart";
    CoinType = "CP"
    Price = 5;
    Damage = "1d4";
    DamageType = "Piercing";
    Weight = 0.25;
    protected string Properties1 = "Finesse"; 
    protected string Properties2 = "Thrown"; // range 20/60
}