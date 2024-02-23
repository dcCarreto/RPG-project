namespace Weapons;

public class Net : Weapon
{
    public Net()
    {
        WeaponRange = "Ranged";
        WeaponProficiency = "Martial";
        Name = "Net";
        CoinType = "GP";
        Price = 1;
        Damage = ""; // TODO: null?
        DamageType = ""; //TODO: null?
        Weight = 3;
        Properties1 = "Special";
        Properties2 = "Thrown"; // range 5/15
        Properties3 = null;
        Properties4 = null;
    }
}