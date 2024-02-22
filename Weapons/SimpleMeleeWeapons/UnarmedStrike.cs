public class UnarmedStrike : Weapons
{
    public UnarmedStrike()
    {
        Range = "Melee";
        WeaponProficiency = "Simple";
        Name = "Unarmed Strike";
        CoinType = string.Empty; // TODO: definir como null.
        Price = 0; // TODO: definir como null.
        Damage = "1d6";
        DamageType = "Bludgeoning";
        Weight = 0; // TODO: definir como null.
        Properties1 = string.Empty;
        Properties2 = string.Empty;
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}