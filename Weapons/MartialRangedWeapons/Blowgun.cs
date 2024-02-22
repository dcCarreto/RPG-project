public class Blowgun : Weapons
{
    public Blowgun()
    {
        Range = "Ranged";
        WeaponProficiency = "Martial";
        Name = "Blowgun";
        CoinType = "GP";
        Price = 10;
        Damage = "1"; // TODO: mudar varType?
        DamageType = "Piercing";
        Weight = 1;
        Properties1 = "Ammunition"; // range 25/100
        Properties2 = "Loading";
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}