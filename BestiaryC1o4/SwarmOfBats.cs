namespace Creatures.BestiaryC1o4
{
    internal class SwarmOfBats : CreatureAttributes
    {

        public SwarmOfBats()
        {
            Name = "Swarm of Bats";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 22 + RollMultiple(8, 5);
            ArmorClass = 12;
            Speed = "0ft, fly 30ft";
            Attributes = [5, 15, 10, 2, 12, 4];
            ChallengeLevel = "1/4";
            Experience = 50;
            DamageResistances = "bludgeoning, piercing, slashing";
            ConditionImmunities = "charmed, frightened, paralyzed, ptrified, prone, restrained, stunned";
            Senses = "blindsight 60ft, passive Perception 11";
            Actions = [
                @"
Bites. Melee Weapon Attack: +4 to hit, reach 0 ft. , one creature
in the swarm 's space. Hit: 5 (2d4) piercing damage, or 2 (1d4)
piercing damage if the swarm has half of its hit points or fewer."
                ];
            Abilities = [
                @"
Echolocation. The swarm can 't use its blindsight
while deafened.",
@"
Keen Hearing. The swarm has advantage on Wisdom
(Perception) checks that rely on hearing.",
@"
Swarm. The swarm can occupy another creature's space and
vice versa, and the swarm can move through any opening large
enough for a Tiny bat. The swarm can't regain hit points or
gain temporary hit points."
                ];
        }
    }
}
