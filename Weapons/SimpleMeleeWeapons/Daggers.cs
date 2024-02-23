namespace Weapons;

public class Dagger : Weapon
{
    public Dagger()
    {
        WeaponRange = "Melee";
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
        Properties3 = null;
    }
}