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

            for (int i = 0; i < AttributeName.Length; i++)
            {
                Console.Write($@"{AttributeName[i]}: {Attributes[i]} ");

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


            EAttack atk = new();
            atk.PerformAttack(AttackList.Beak, DamageTypes.Acid, RangeTypes.Melee, 8);
        }
    }
}
