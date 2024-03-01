namespace Creatures.BestiaryC1o4
{
    internal class SwarmOfRavens : Creatures
    {

        public SwarmOfRavens()
        {
            Name = "Swarm of Ravens";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 24 + RollMultiple(8, 7) - 7;
            ArmorClass = 12;
            Speed = "10ft, fly 50ft";
            Attributes = [6, 14, 8, 3, 12, 6];
            ChallengeLevel = "1/4";
            Experience = 50;
            DamageResistances = "bludgeoning, piercing, slashing";
            ConditionImmunities = "charmed, fightened, paralyzed, petrified, prine, restrained, stunned";
            Skills = "Perception +5";
            Senses = "passive Perception 15";
            Actions = [
                @"
Beaks. Melee Weapon Attack: +4 to hit, reach 5 ft, one target
in the swarm's space. Hit: 7 (2d6) pi ercing damage, or 3 (1d6)
piercing damage if the swarm has half of its hit points or fewer."
                ];
            Abilities = [
                @"
Swarm. The swarm can occupy another creature's space and
vice versa, and the swarm can move through any opening large
enough for a Tiny raven . The swarm can't regain hit points or
gain temporary hit points."
                ];
        }
    }
}
