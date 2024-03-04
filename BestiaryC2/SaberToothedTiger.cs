namespace Creatures.BestiaryC2
{
    internal class SaberToothedTiger : CreatureAttributes
    {
        public SaberToothedTiger() 
        {
            Name = "Saber-Toothed Tiger";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 52 + RollMultiple(10, 7) + 14;
            ArmorClass = 12;
            Speed = "40ft";
            Attributes = [18, 14, 15, 3, 12, 8];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +3, Stealth +6";
            Senses = "passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +6 to hit, reach 5 ft ., one target.
Hit: 10 (1d10 + 5) piercing damage.",
                @"
Claw. Melee Weapon Attack: +6 to hit , reach 5 ft., one target.
Hit: 12 (2d6 + 5) slashing damage."
                ];
            Abilities = [
                @"
Keen Smell. The tiger has advantage on Wisdom (Perception)
checks that rely on smell.",
                @"
Pounce. If the tiger moves at least 20 feet straight toward a
creature and then hits it with a claw attack on the same turn,
that target must succeed on a DC 14 Strength saving throw or
be knocked prone. If the target is prone, the tiger can make one
bite attack against it as a bonus action."
                ];
        }
    }
}
