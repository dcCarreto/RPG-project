namespace Creatures.BestiaryC1o2
{
    internal class SwarmOfInsects : Creatures
    {
        readonly Dices dice = new();
        public SwarmOfInsects()
        {
            Name = "Swarm of Insects";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 22 + dice.RollMultiple(dice.d8, 5);
            ArmorClass = 12;
            Speed = "20ft, climb 20ft";
            Attributes = [3, 13, 10, 1, 7, 1];
            ChallengeLevel = "1/2";
            Experience = 100;
            DamageResistances = "bludgeoning, piercing, slashing";
            ConditionImmunities = "charmed, frightened, paralyzed, petrified, prone, restrained, stuinned";
            Senses = "blindsight 10ft, passive Perception 8";
            Actions = [
                @"
Bites. Melee Weapon Attack: +3 to hit, reach 0 ft., one target in
the swarm's space. Hit: 10 (4d4) piercing damage, or 5 (2d4)
piercing damage if the swarm has half of its hit points or fewer."
                ];
            Abilities = [
                @"
Swarm. The swarm can occupy another creature's space and
vice versa, and the swarm can move through any opening large
enough for a Tiny insect. The swarm can't regain hit points or
gain temporary hit points."
                ];
        }
    }
}
