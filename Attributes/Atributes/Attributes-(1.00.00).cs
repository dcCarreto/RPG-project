public class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Vitality { get; set; }
    public int Intelligence { get; set; }
    public int Charisma { get; set; }
    public int Wisdom { get; set; }

    // Method to display attributes
    public void DisplayAttributes()
    {
        Console.WriteLine($"Attributes for {Name}:");
        Console.WriteLine($"Strength: {Strength} (mod: {CalculateMod(Strength)})");
        Console.WriteLine($"Agility: {Agility} (mod: {CalculateMod(Agility)})");
        Console.WriteLine($"Vitality: {Vitality} (mod: {CalculateMod(Vitality)})");
        Console.WriteLine($"Intelligence: {Intelligence} (mod: {CalculateMod(Intelligence)})");
        Console.WriteLine($"Charisma: {Charisma} (mod: {CalculateMod(Charisma)})");
        Console.WriteLine($"Wisdom: {Wisdom} (mod: {CalculateMod(Wisdom)})");
    }

    // Method to calculate mod based on attribute value
    public int CalculateMod(int attributeValue)
    {
        if (attributeValue < 0) // End if the attributes are negative
            return -1;
        else if (attributeValue < 6)
            return -3;
        else if (attributeValue < 8)
            return -2;
        else if (attributeValue < 10)
            return 0;
        else if (attributeValue < 12)
            return 1;
        else if (attributeValue < 14)
            return 2;
        else if (attributeValue < 16)
            return 3;
        else if (attributeValue < 18)
            return 4;
        else if (attributeValue < 20)
            return 5;
        else
            return -1; // Handle case where attribute value is 20 or higher
    }
}