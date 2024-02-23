namespace Weapons;

public class OneHandedCrossbow : Weapon
{
    public OneHandedCrossbow()
    {
        WeaponRange = "Ranged";
        WeaponProficiency = "Martial";
        Name = "One Handed Crossbow";
        CoinType = "GP";
        Price = 75;
        Damage = "1d6"; // TODO: mudar varType?
        DamageType = "Piercing";
        Weight = 3;
        Properties1 = "Ammunition"; // range 30/120
        Properties2 = "Light";
        Properties3 = "Loading";
        Properties4 = null;
    }
}