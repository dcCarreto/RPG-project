namespace Weapons;

public class UnarmedStrike : Weapon
{
    public UnarmedStrike()
    {
        WeaponRange = "Melee";
        WeaponProficiency = "Simple";
        Name = "Unarmed Strike";
        CoinType = string.Empty; // TODO: definir como null.
        Price = 0; // TODO: definir como null.
        Damage = "1d6";
        DamageType = "Bludgeoning";
        Weight = 0; // TODO: definir como null.
        Properties1 = null;
        Properties2 = null;
        Properties3 = null;
        Properties4 = null;
    }
}