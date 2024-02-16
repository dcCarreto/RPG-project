namespace WeaponsMain.Weapons;

public class Sling : Weapons
{
    Range = "Ranged";
    WeaponProficiency = "Simple";
    Name = "Sling";
    CoinType = "SP"
    Price = 1;
    Damage = "1d4";
    DamageType = "Bludgeoning";
    Weight = 0; // TODO: definir como null.
    protected string Properties1 = "Ammunition"; // range 30/120 
}