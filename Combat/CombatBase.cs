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

                    if (target.HitPoints <= 0 || attacker.HitPoints <= 0)
                    {
                        break;
                    }

                    Console.WriteLine($"\n--- Round {rounds}  ---");
                    rounds++;

                    AttackRound(target, attacker);

                    if (attacker.HitPoints <= 0 || target.HitPoints <= 0)
                    {
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

        private static int RollDice(string diceNotation)
        {
            string[] parts = diceNotation.Split('d');

            if (parts.Length < 2)
            {
                Console.WriteLine("Invalid dice notation: " + diceNotation);
                return 0;
            } else if (parts.Length == 0)
            {
               
            }

            int numberOfDice = int.Parse(parts[0]);

            string[] modifierParts = parts[1].Split('+');

            if (modifierParts.Length < 1)
            {
                Console.WriteLine("Invalid dice notation: " + diceNotation);
                return 0;
            }

            int numberOfSides = int.Parse(modifierParts[0]);

            int modifier = 0;

            if (modifierParts.Length > 1)
            {
                modifier = int.Parse(modifierParts[1]);
            }

            Random random = new Random();
            int result = 0;

            for (int i = 0; i < numberOfDice; i++)
            {
                if (numberOfSides == 1)
                {
                    result += 1;
                }
                else
                {
                    result += random.Next(1, numberOfSides + 1);
                }
            }

            result += modifier;

            return result;
        }


        private static void AttackTarget(Creature attacker, Creature target)
        {
            Console.WriteLine("Attack!\n");

            Random random = new Random();

            var selectedAttack = attacker.Attacks[random.Next(attacker.Attacks.Count)];

            Console.WriteLine($"--- {attacker.Name} used {selectedAttack.AtkName}! ---");
            Console.WriteLine($"{selectedAttack.Types}, {selectedAttack.Range}, Damage: {selectedAttack.Dice}");

            int d20 = random.Next(1, 21);
            Console.WriteLine($"Attack Roll: {d20}");

            if (d20 >= target.ArmorClass)
            {
                int damage = RollDice(selectedAttack.Dice);
                if (d20 == 20)
                {
                    Console.WriteLine("Double Damage!");
                    damage *= 2;
                }

                if (selectedAttack.Range == RangeTypes.Melee)
                {
                    damage += ((attacker.Attributes[0] - 10) / 2);
                }
                else if (selectedAttack.Range == RangeTypes.Ranged)
                {
                    damage += ((attacker.Attributes[1] - 10) / 2);
                }
                if (damage < 0)
                {
                    damage = 1;
                }

                Console.WriteLine($"Hit! Dealing {damage} damage to {target.Name}!");
                target.HitPoints -= damage;
                Console.WriteLine($"{target.Name}'s remaining HP: {target.HitPoints}");

                if (target.HitPoints <= 0)
                {
                    Console.WriteLine($"{target.Name} has been defeated! {attacker.Name} is victorious!");
                }
                else if (attacker.HitPoints <= 0)
                {
                    Console.WriteLine($"{attacker.Name} has been defeated! {target.Name} is victorious!");
                }
            }
            else
            {
                Console.WriteLine("Miss! No damage dealt.");
            }
        }
    }
}

