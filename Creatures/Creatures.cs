using Creatures.Bestiary;
using System.Reflection;


namespace Creatures;


public class Creatures
{

    protected string Name { get; set; }
    protected string Size { get; set; }
    protected string Descriptor { get; set; }
    protected int HitPoints { get; set; }
    protected int Displacement { get; set; }
    protected int Str { get; set; }
    protected int Dex { get; set; }
    protected int Cons { get; set; }
    protected int Intl { get; set; }
    protected int Cha { get; set; }
    protected string ChallengeLevel { get; set; }
    protected int Experience { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Size: {Size}");
        Console.WriteLine($"Descriptor: {Descriptor}");
        Console.WriteLine($"Hitpoints: {HitPoints}");
        Console.WriteLine($"Displacement: {Displacement}");
        Console.WriteLine($"Strength: {Str}");
        Console.WriteLine($"Dexterity: {Dex}");
        Console.WriteLine($"Constitution: {Cons}");
        Console.WriteLine($"Intelligence: {Intl}");
        Console.WriteLine($"Charisma: {Cha}");
        Console.WriteLine($"ChallengeLevel: {ChallengeLevel}");
        Console.WriteLine($"EXP: {Experience}");
    }



    static void Main(string[] args)
    {
        Console.Write(@"Enter the Name of the creature to be displayed:
(por enquanto só tem Guincher e CriaturaTeste: ");
        string className = Console.ReadLine()!;
        Type[] types = Assembly.GetExecutingAssembly().GetTypes();
        var creatureTypes = types.Where(t => t.IsSubclassOf(typeof(Creatures)));
        Type selectedType = creatureTypes.FirstOrDefault(t => t.Name == className);

        if (selectedType != null)
        {
            object instance = Activator.CreateInstance(selectedType);

            if (instance is Creatures creatureInstance)
            {
                creatureInstance.DisplayInfo();
            }
        }
        else
        {
            Console.WriteLine($"Invalid or not found Creature: {className} please restart.");
        }
    }
}