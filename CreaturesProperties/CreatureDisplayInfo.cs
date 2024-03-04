namespace Creatures
{
    public partial class CreatureAttributes
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
