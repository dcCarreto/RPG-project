namespace Creatures
{
    public partial class Creature
    {
        public List<Condition> Conditions { get; set; } = new List<Condition>();

        public void ApplyConditions()
        {
            foreach (var condition in Conditions.ToList())
            {
                condition.ApplyEffect(this);
                condition.Duration--;

                if (condition.Duration <= 0)
                {
                    Conditions.Remove(condition);
                    Console.WriteLine($"{Name} is no longer {condition.Name}.");
                }
            }
        }
    }
}
