namespace Weapons;

public class Blowgun : Weapon
{
    public Blowgun()
    {
        WeaponRange = "Ranged";
        WeaponProficiency = "Martial";
        Name = "Blowgun";
        CoinType = "GP";
        Price = 10;
        Damage = "1"; // TODO: mudar varType?
        DamageType = "Piercing";
        Weight = 1;
        Properties1 = "Ammunition"; // range 25/100
        Properties2 = "Loading";
        Properties3 = null;
        Properties4 = null;
    }
}