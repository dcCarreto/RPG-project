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
                    continue;

                Console.WriteLine($"{property.Name}: {property.GetValue(this)}");
            }

            Console.WriteLine("Attributes: " + string.Join(", ", Attributes));

            PrintArray("Actions", Actions);
            PrintArray("Abilities", Abilities);

            void PrintArray(string title, string[] array)
            {
                if (array != null && array.Length > 0)
                {
                    Console.WriteLine($"\n{title}:");
                    foreach (var item in array)
                    {
                        Console.WriteLine($" - {item}");
                    }
                }
            }
        }
    }

    public partial class Creature
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nAvailable Creatures @ README.md");
                Console.Write("Enter the Name of the creature to be displayed: ");

                string className = Console.ReadLine()!;
                Type[] types = Assembly.GetExecutingAssembly().GetTypes();
                var creatureTypes = types.Where(t => t.IsSubclassOf(typeof(Creatures)));
                Type selectedType = creatureTypes.FirstOrDefault(t => t.Name == className);

                if (selectedType != null)
                {
                    Creatures creatureInstance = (Creatures)Activator.CreateInstance(selectedType)!;
                    creatureInstance.DisplayInfo();
                    Console.WriteLine("------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"\nInvalid or not found Creature: {className} please restart.\n");
                    break;
                }
            }
        }
    }

}
