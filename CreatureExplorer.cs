using System;
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;

namespace Creatures
{
    public partial class Creatures
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Alignment: {Alignment}");
            Console.WriteLine($"Hitpoints: {HitPoints}");
            Console.WriteLine($"Armor Class: {ArmorClass}");
            Console.WriteLine($"Speed: {Speed}");

            foreach (var property in GetType().GetProperties())
            {
                if (property.Name == "AttributeName" || property.Name == "Attributes" || property.PropertyType.IsArray)
                {
                    continue;
                }

                Console.WriteLine($"{property.Name}: {property.GetValue(this)}");
            }

            Console.WriteLine("Attributes:");
            for (int i = 0; i < Attributes.Length; i++)
            {
                Console.Write($"{AttributeName[i]}: {Attributes[i]}, ");
            }
            Console.WriteLine("");

            if (Actions != null && Actions.Length >= 0)
            {
                Console.WriteLine(@"
Actions:");
                foreach (var action in Actions)
                {
                    Console.WriteLine($" - {action}");
                }
            }

            if (Abilities != null && Abilities.Length >= 0)
            {
                Console.WriteLine(@"
Abilities:");
                foreach (var ability in Abilities)
                {
                    Console.WriteLine($"  - {ability}");
                }
            }
            else
            {
            }
        }
    }

    public partial class Creature
    {
        static void Main(string[] args)
        {
            bool ativo = true;

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
Pony, SlaadTadpole, Stirge, TribalWarrior, TwigBlight
");

                Console.Write(@"
Enter the Name of the creature to be displayed: ");

                string className = Console.ReadLine()!;
                Type[] types = Assembly.GetExecutingAssembly().GetTypes();
                var creatureTypes = types.Where(t => t.IsSubclassOf(typeof(Creatures)));
                Type selectedType = creatureTypes.FirstOrDefault(t => t.Name == className)!;

                if (selectedType != null)
                {
                    object instance = Activator.CreateInstance(selectedType)!;
                    if (instance is Creatures creatureInstance)
                    {
                        creatureInstance.DisplayInfo();
                    }
                }
                else
                {
                    Console.WriteLine($@"
Invalid or not found Creature: {className} please restart.
");
                    ativo = false;
                }
            } while (ativo);
        }
    }
}
