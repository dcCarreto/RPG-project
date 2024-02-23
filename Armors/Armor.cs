namespace Armors;

public class Armor
{
    private string? armorType;
    private int armorClass;
    private string? name;
    private string? coinType;
    private int price;
    private string? requirements;
    private string? stealth;
    private double weight;

    public string? ArmorType { get => armorType; set => armorType = value; }
    public int ArmorClass { get => armorClass; set => armorClass = value; }
    public string? Name { get => name; set => name = value; }
    public string? CoinType { get => coinType; set => coinType = value; }
    public int Price { get => price; set => price = value; }
    public string? Requirements { get => requirements; set => requirements = value; }
    public string? Stealth { get => stealth; set => stealth = value; }
    public double Weight { get => weight; set => weight = value; }
}