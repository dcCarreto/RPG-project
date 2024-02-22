public class Net : Weapons
{
    public Net()
    {
        Range = "Ranged";
        WeaponProficiency = "Martial";
        Name = "Net";
        CoinType = "GP";
        Price = 1;
        Damage = ""; // TODO: null?
        DamageType = ""; //TODO: null?
        Weight = 3;
        Properties1 = "Special";
        Properties2 = "Thrown"; // range 5/15
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}