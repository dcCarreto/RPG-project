namespace Creatures.BestiaryC0
{
    internal class Shrieker : Creature
    {

        public Shrieker()
        {
            Name = "Shrieker";
            Type = pl;
            Size = m;
            Alignment = ud;
            HitPoints = 13 + RollMultiple(8, 3); ;
            Attributes = [10, 5, 11, 1, 3, 3];
            ArmorClass = 5;
            Speed = "0";
            Experience = 10;
            ChallengeLevel = "0";
            ConditionImmunities = "blinded, deafened, frightened";
            Senses = "blindsight 30ft (blind beyond thi radius, passive Perception 6";
            Reactions = @"
Shriek. When a bright light or a creature is within 30 feet of the Shrieker,
it emits a shriek audible within 300 feet of it. The Shrieker continues to
shriek until disturbance moves out of range and for (1d41) of the Shrieker`s
turns afterward.";
            Abilities = [
                @"
False Appearance: While the Shrieker remains motionless, it is indistinguishable from an ordinary fungus"
           ];
        }
    }
}