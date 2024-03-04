using System.Reflection;

namespace Creatures
{
    public partial class CreatureAttributes
    {
        public static void CreaturesMain()
        {
            while (true)
            {
                Console.WriteLine("\nCreature names available @ README.md");
                Console.Write("Enter creature name to be displayed (case sensitive): ");

                string className = Console.ReadLine()!;
                Type[] types = Assembly.GetExecutingAssembly().GetTypes();
                var creatureTypes = types.Where(t => t.IsSubclassOf(typeof(CreatureAttributes)));
                Type? selectedType = creatureTypes.FirstOrDefault(t => t.Name == className);

                if (selectedType != null)
                {
                    CreatureAttributes creatureInstance = (CreatureAttributes)Activator.CreateInstance(selectedType)!;
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
    }
}
