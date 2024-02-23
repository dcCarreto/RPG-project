namespace Weapons;

public class Weapon
{
    private string? weaponRange;
    private string? weaponProficiency;
    private string? name;
    private string? coinType;
    private int price;
    private string? damage;
    private string? damageType;
    private double weight;
    private string? properties1;
    private string? properties2;
    private string? properties3;
    private string? properties4;

    public string? WeaponRange { get => weaponRange; set => weaponRange = value; }
    public string? WeaponProficiency { get => weaponProficiency; set => weaponProficiency = value; }
    public string? Name { get => name; set => name = value; }
    public string? CoinType { get => coinType; set => coinType = value; }
    public int Price { get => price; set => price = value; }
    public string? Damage { get => damage; set => damage = value; }
    public string? DamageType { get => damageType; set => damageType = value; }
    public double Weight { get => weight; set => weight = value; }
    public string? Properties1 { get => properties1; set => properties1 = value; }
    public string? Properties2 { get => properties2; set => properties2 = value; }
    public string? Properties3 { get => properties3; set => properties3 = value; }
    public string? Properties4 { get => properties4; set => properties4 = value; }
}
