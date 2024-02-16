namespace WeaponsMain.Weapons;

public class OneHandedCrossbow : Weapons
{
    Range = "Ranged";
    WeaponProficiency = "Martial";
    Name = "One Handed Crossbow";
    CoinType = "GP"
    Price = 75;
    Damage = "1d6"; // TODO: mudar varType?
    DamageType = "Piercing";
    Weight = 3;
    protected string Properties1 = "Ammunition"; // range 30/120
    protected string Properties2 = "Light";
    protected string Properties3 = "Loading";
}