using Base;

namespace BestiaryIndex.BestiaryC2
{
    internal class SwarmOfPoisonousSnakes : Creature
    {
        public SwarmOfPoisonousSnakes()
        {
            Name = "Swarm of Poisonous Snakes";
            Type = CreatureTypes.Beast;
            Size = Sizes.Medium;
            Alignment = Alignments.Unaligned;
            HitPoints = 36 + RollMultiple(8, 8);
            ArmorClass = 14;
            Speed = "30ft, swim 30ft";
            AttributeValue = [8, 18, 11, 1, 10, 3];
            ChallengeLevel = "2";
            Experience = 450;
            Actions = [
                @"
Bites. Melee Weapon Attack: +6 to hit, reach 0 ft ., one creature
in the swarm's space. Hit: 7 (2d6) piercing damage, or 3 (1d6)
piercing damage if the swarm has half of its hit points or fewer.
The target must make a DC 10 Constitution saving throw,
taking 14 (4d6) poison damage on a failed save, or half as
much damage on a successful one."
                ];
            Abilities = [
                @"
Swarm. The swarm can occupy another creature's space and
vice versa, and the swarm can move through any opening large
enough for a Tiny snake. The swarm can't regain hit points or
gain temporary hit points."
                ];
        }
    }
}
