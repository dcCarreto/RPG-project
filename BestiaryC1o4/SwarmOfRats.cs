namespace Creatures.BestiaryC1o4
{
    internal class SwarmOfRats : Creature
    {

        public SwarmOfRats()
        {
            Name = "Swarm of Rats";
            Type = Types.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 20 + RollMultiple(8, 7) - 7;
            ArmorClass = 10;
            Speed = "30ft";
            Attributes = [9, 11, 9, 2, 10, 3];
            ChallengeLevel = "1/4";
            Experience = 50;
            DamageResistances = "bludgeoning, piercing, slashin";
            ConditionImmunities = "charmed, frightened, paralyzed, petrified, prone, restrained, stunned";
            Senses = "darkvision 30ft, passive Perceptioon 10";
            Actions = [
                @"
Bites. Melee Weapon Attack: +2 to hit, reach 0 ft. , one target in
the swarm's space. Hit: 7 (2d6) piercing damage, or 3 (1d6)
piercing damage if the swarm has half of its hit points or fewer."
                ];
            Abilities = [
                @"
Keen Smell. The swarm has advantage on Wisdom (Perception)
checks that rely on smell.",
                @"
Swarm. The swarm can occupy another creature's space and
vice versa, and the swarm can move through any opening large
enough for a Tiny rat. The swarm can 't regain hit points or gain
temporary hit points."
                ];
        }
    }
}
