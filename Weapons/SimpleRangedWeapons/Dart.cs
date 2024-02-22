public class Dart : Weapons
{
    public Dart()
    {
        Range = "Ranged";
        WeaponProficiency = "Simple";
        Name = "Dart";
        CoinType = "CP";
        Price = 5;
        Damage = "1d4";
        DamageType = "Piercing";
        Weight = 0.25;
        Properties1 = "Finesse";
        Properties2 = "Thrown"; // range 20/60
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}