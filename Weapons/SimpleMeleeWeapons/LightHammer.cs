public class LightHammer : Weapons
{
    public LightHammer()
    {
        Range = "Melee";
        WeaponProficiency = "Simple";
        Name = "Light Hammer";
        CoinType = "GP";
        Price = 2;
        Damage = "1d6";
        DamageType = "Bludgeoning";
        Weight = 4;
        Properties1 = "Light";
        Properties2 = "Thrown"; // range 20/60
        Properties3 = string.Empty;
        Properties4 = string.Empty;
    }
}