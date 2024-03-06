namespace Creatures
{
    public abstract class Condition
    {
        public string Name { get; }
        public int Duration { get; set; }

        protected Condition(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public abstract void ApplyEffect(Creature creature);
    }

    public class PoisonCondition : Condition
    {
        public PoisonCondition(int duration) : base("Poisoned", duration) { }

        public override void ApplyEffect(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is poisoned! Taking damage over time.");
            int damage = 2;
            creature.HitPoints -= damage;
            Console.WriteLine($"{creature.Name} takes {damage} damage from poison. Remaining HP: {creature.HitPoints}");
        }
    }

    public class BurningCondition : Condition
    {
        public BurningCondition(int duration) : base("Burning", duration) { }

        public override void ApplyEffect(Creature creature)
        {
            Console.WriteLine($"{creature.Name} is burning! Taking fire damage.");            
            int damage = 3;
            creature.HitPoints -= damage;
            Console.WriteLine($"{creature.Name} takes {damage} fire damage. Remaining HP: {creature.HitPoints}");
        }
    } 
}
