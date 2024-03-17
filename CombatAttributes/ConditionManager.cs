namespace Creatures
{

    public class ConditionManager
    {       
        public static void ApplyCondition(Creature creature, Conditions condition)
        {
            switch (condition)
            {
                case Conditions.Blinded:
                    ApplyBlindedCondition(creature);
                    break;
                case Conditions.Charmed:
                    ApplyCharmedCondition(creature);
                    break;
                case Conditions.Deafened:
                    ApplyDeafenedCondition(creature);
                    break;
                case Conditions.Frightened:
                    ApplyFrightenedCondition(creature);
                    break;
                case Conditions.Grappled:
                    ApplyGrappledCondition(creature);
                    break;
                case Conditions.Incapacitated:
                    ApplyIncapacitatedCondition(creature);
                    break;                   
                case Conditions.Paralyzed:
                    ApplyParalyzedCondition(creature);
                    break;
                case Conditions.Petrified:
                    ApplyPetrifiedCondition(creature);
                    break;
                case Conditions.Poisoned:
                    ApplyPoisonedCondition(creature);
                    break;
                case Conditions.Prone:
                    ApplyProneCondition(creature);
                    break;
                case Conditions.Restrained:
                    ApplyRestrainedCondition(creature);
                    break;
                case Conditions.Stunned:
                    ApplyStunnedCondition(creature);
                    break;
                case Conditions.Unconscious:
                    ApplyUnconsciousCondition(creature);
                    break;
                default:
                    Console.WriteLine($"Unknown condition: {condition}");
                    break;
            }
        }

        private static void ApplyBlindedCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now blinded!");
        }
        private static void ApplyCharmedCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now charmed!");
        }
        private static void ApplyGrappledCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now grappled!");
        }
        private static void ApplyFrightenedCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now frightened!");
        }
        private static void ApplyDeafenedCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now deafened!");
        }
        private static void ApplyIncapacitatedCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now incapacitated!");
        }
        private static void ApplyParalyzedCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now paralyzed!");
        }
        private static void ApplyPetrifiedCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now petrified!");
        }
        private static void ApplyPoisonedCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now poisoned!");
        }
        private static void ApplyProneCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now prone!");
        }
        private static void ApplyRestrainedCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now restrained!");
        }
        private static void ApplyStunnedCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now stunned!");
        }
        private static void ApplyUnconsciousCondition(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is now unconscious!");
        }
        
    }
}