namespace Weapons;

public class Dart : Weapon
{
    public Dart()
    {
        WeaponRange = "Ranged";
        WeaponProficiency = "Simple";
        Name = "Dart";
        CoinType = "CP";
        Price = 5;
        Damage = "1d4";
        DamageType = "Piercing";
        Weight = 0.25;
        Properties1 = "Finesse";
        Properties2 = "Thrown"; // range 20/60
        Properties3 = null;
        Properties4 = null;
    }
}