using System.Reflection;

namespace Creatures
{
    public class CombatBase
    {
        public static void CombatMain()
        {
            Console.WriteLine("\nCreature names available @ README.md");
            Console.Write("Enter Attacker name : ");
            string attackerClassName = Console.ReadLine()!;

            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            var creatureTypes = types.Where(t => t.IsSubclassOf(typeof(Creature)));

            Type? attackerType = creatureTypes.FirstOrDefault(t => t.Name == attackerClassName);

            Console.Write("Enter Target name : ");
            string targetClassName = Console.ReadLine()!;

            Type? targetType = creatureTypes.FirstOrDefault(t => t.Name == targetClassName);

            int rounds = 1;
            if (attackerType != null && targetType != null)
            {
                Creature attacker = (Creature)Activator.CreateInstance(attackerType);
                Creature target = (Creature)Activator.CreateInstance(targetType);

                Console.WriteLine("Attacker:");
                DisplayCreatureInfo(attacker);
                Console.WriteLine("\nTarget:");
                DisplayCreatureInfo(target);

                
                while (attacker.HitPoints > 0 && target.HitPoints > 0)
                {
                    Console.WriteLine($"\n--- Round {rounds}  ---");
                    rounds++;

                    AttackRound(attacker, target);
                    if (target.HitPoints <= 0)
                    {
                        Console.WriteLine($"{target.Name} has been defeated! {attacker.Name} is victorious!");
                        break;
                    }

                    AttackRound(target, attacker);
                    if (attacker.HitPoints <= 0)
                    {
                        Console.WriteLine($"{attacker.Name} has been defeated! {target.Name} is victorious!");
                        break;
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Invalid creature types. Please enter valid attacker and target names.");
                
            }
        }

        private static void DisplayCreatureInfo(Creature creature)
        {
            Console.WriteLine($@"
Name: {creature.Name}
HP: {creature.HitPoints}
CA: {creature.ArmorClass}
Str: {creature.Attributes[0]}
Dex: {creature.Attributes[1]}
Con: {creature.Attributes[2]}
Int: {creature.Attributes[3]}
Wis: {creature.Attributes[4]}
Cha: {creature.Attributes[5]}
");
        }

        private static void AttackRound(Creature attacker, Creature target)
        {
            Console.WriteLine($"\n{attacker.Name}'s Turn:");
            AttackTarget(attacker, target);
            if (target.HitPoints > 0)
            {
                Console.WriteLine($"\n{target.Name}'s Turn:");
                AttackTarget(target, attacker);
            }
        }

        private static void AttackTarget(Creature attacker, Creature target)
        {
            Creature dice = new();
            Console.WriteLine("Attack!");

            Random random = new Random();            
            int d20 = dice.Roll(20);
            

            Console.WriteLine($"Attack Roll: {d20}");

            if (d20 >= target.ArmorClass)
            {
                int damage = random.Next(1, 11);
                if (d20 == 20)
                {
                    Console.WriteLine("Double Damage!");
                    damage *= 2;
                }
                if (attacker.Range == RangeTypes.Melee)
                {
                    damage += ((attacker.Attributes[0] - 10) /2);
                }
                else if (attacker.Range == RangeTypes.Ranged)
                {
                    damage += ((attacker.Attributes[1] - 10) /2);
                }
                Console.WriteLine($"Hit! Dealing {damage} damage to {target.Name}!");
                target.HitPoints -= damage;
                Console.WriteLine($"{target.Name}'s remaining HP: {target.HitPoints}");
            }
            else
            {
                Console.WriteLine("Miss! No damage dealt.");
            }
        }
    }
}
