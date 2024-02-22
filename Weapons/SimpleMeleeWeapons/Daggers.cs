public class Dagger : Weapons
{
    public Dagger()
    {
        Range = "Melee";
        WeaponProficiency = "Simple";
        Name = "Dagger";
        CoinType = "GP";
        Price = 2;
        Damage = "1d4";
        DamageType = "Piercing";
        Weight = 1;
        Properties1 = "Finesse";
        Properties2 = "Light";
        Properties3 = "Thrown"; // range 20/60
        Properties3 = string.Empty;
    }
}