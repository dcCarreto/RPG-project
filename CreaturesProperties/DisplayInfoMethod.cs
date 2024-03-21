using System.Reflection;

namespace Base
{
    public partial class Creature
    {
        public static void CreaturesMain()
        {
            while (true)
            {
                Console.WriteLine("\nCreature names available @ README.md");
                Console.Write("Enter creature name to be displayed (case sensitive): ");

                string className = Console.ReadLine()!;
                Type[] types = Assembly.GetExecutingAssembly().GetTypes();
                var creatureTypes = types.Where(t => t.IsSubclassOf(typeof(Creature)));
                Type? selectedType = creatureTypes.FirstOrDefault(t => t.Name == className);

                if (selectedType != null)
                {
                    Creature creatureInstance = (Creature)Activator.CreateInstance(selectedType)!;
                    creatureInstance.DisplayInfo();
                    Console.WriteLine("------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"\nInvalid or not found Creature: {className}, please restart.\n");
                    break;
                }
            }            
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Alignment: {Alignment}");
            Console.WriteLine($"Hitpoints: {HitPoints}");
            Console.WriteLine($"Armor Class: {ArmorClass}");
            Console.WriteLine($"Speed: {Speed}");

            for (int i = 0; i < AttributeName.Length; i++)
            {
                int modifier = CalculateModifier(Attributes[i]);
                Console.Write($"{AttributeName[i]}: {Attributes[i]} Modifier: {modifier} \n");
            }

            PrintArray("Actions", Actions!);
            PrintArray("Abilities", Abilities!);

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
}
