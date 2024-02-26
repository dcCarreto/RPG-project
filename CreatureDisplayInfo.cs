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
