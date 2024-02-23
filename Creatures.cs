using System.Reflection;

namespace Creatures;

public class Creatures
{
    public string 
    t = "Tiny", s = "Small", m = "Medium",
    l = "Large", h = "Huge", g = "Gargantuan", 
    lg = "Lawful Good", ng = "Neutral Good", cg = "Chaotic Good",
    ln = "Lawful Neutral", n = "Neutral", cn = "Chaotic Neutral",
    le = "Lawful Evil", ne = "Neutral Evil", ce = "Chaotic Evil",
    aa = "Any Alignment", ud = "Unaligned", ana = "Any non-good alignment",
    ab = "Aberration", ba = "Beast", cl = "Celestial",
    co = "Construct", dr = "Dragon", el = "Elemental",
    fy= "Fey", fi = "Fiend", gi = "Giant",
    hu = "Humanoid", mo = "Monstruosity", oo = "Ooze",
    pl = "Plant", un = "Undead";
    protected string ?Name { get; set; }
    protected string ?Type { get; set; }
    protected string ?Size { get; set; }
    protected string ?Alignment { get; set; }
    protected int HitPoints { get; set; }
    protected int ArmorClass { get; set; }
    protected string ?Speed { get; set; }
    protected string[] AttributeName = ["Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"];
    protected int[] ?Attributes { get; set; }
    protected string ?ChallengeLevel { get; set; }
    protected int Experience { get; set; }
    protected string ?SavingThrows { get; set; }
    protected string ?DamageImmunities { get; set; }
    protected string ?DamageResistances { get; set; }
    protected string ?DamageVulnerabilities { get; set; }
    protected string ?ConditionImmunities { get; set; }
    protected string ?ConditionResistances { get; set; }
    protected string ?Skills { get; set; }
    protected string ?Senses { get; set; }
    protected string ?Languages { get; set; }
    protected string[] ?Actions { get; set; }
    protected string ?Reactions { get; set; }
    protected string[] ?Abilities { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Size: {Size}");
        Console.WriteLine($"Alignment: {Alignment}");
        Console.WriteLine($"Hitpoints: {HitPoints}");
        Console.WriteLine($"Armor Class: {ArmorClass}");
        Console.WriteLine($"Speed: {Speed}");

        foreach (var property in this.GetType().GetProperties())
        {
            if (property.Name == "AttributeName" || property.Name == "Attributes" || property.Name == "Abilities")
            {
                continue;
            }

            if (property.PropertyType.IsArray)
            {
                continue;
            }

            var value = property.GetValue(this);
            if (value != null)
            {
                Console.WriteLine($"{property.Name}: {value}");
            }
        }

        Console.WriteLine("Attributes:");
        for (int i = 0; i < Attributes.Length; i++)
        {
            Console.Write($"{AttributeName[i]}: {Attributes[i]}, ");
        }
        Console.WriteLine("");

        if (Actions != null && Actions.Length > 0)
        {
            Console.WriteLine("Actions:");
            foreach (var action in Actions)
            {
                Console.WriteLine($" - {action}");
            }
        }


        if (Abilities != null && Abilities.Length > 0)
        {
            Console.WriteLine("Abilities:");
            foreach (var ability in Abilities)
            {
                Console.WriteLine($"  - {ability}");
            }
        } else
        {
            Console.WriteLine(@"

Abilities = None");
        }
    }

    static void Main(string[] args)
    {
        EAttack eAttack = new();
        bool ativo = true;

        eAttack.PerformAttack("Rake", "Poison", "Melee", 6);

        
        do
        {
            Console.WriteLine(@"
        
        ");

            Console.WriteLine(@"
Available Creatures {Challenge Level 0}

AwakenedShrub, Baboon, Badger, Bat, Cat, Commoner,
Crab, CrawlingClaw, Deer, Eagle, Frog, GiantFireBeetle,
Goat, Hawk, Homunculus, Hyena, Jackal, Lemure,
Lizard, MyconidSprout, Octopus, Owl, Quipper,
Rat, Raven, Scorpion, SeaHorse, Shrieker, Spider,
Vulture, Weasel
");

            Console.WriteLine(@"
Available Creatures {Challenge Level 1/8}  

Bandit, BloodHawk, Camel, Cultist, Flumph, FlyingSnake,
GiantCrab, GiantRat, GiantWeasel, Guard, Kobold, Manes,
Mastiff, Merfolk, Monodrone, Mule, Noble, PoisonousSnake,
Pony, SlaadTadpole, Stirge, TribalWarrior
");

            Console.Write(@"
Enter the Name of the creature to be displayed: ");

            string className = Console.ReadLine()!;
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            var creatureTypes = types.Where(t => t.IsSubclassOf(typeof(Creatures)));
            Type selectedType = creatureTypes.FirstOrDefault(t => t.Name == className)!;

            if (selectedType != null) {
                object instance = Activator.CreateInstance(selectedType)!;
                if (instance is Creatures creatureInstance)                {
                    creatureInstance.DisplayInfo();
                }
            }
            else { 
                Console.WriteLine($@"
Invalid or not found Creature: {className} please restart.
");
                ativo = false;
            }
        } while (ativo);

        
    }
}
