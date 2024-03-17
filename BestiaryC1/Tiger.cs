namespace Creatures.BestiaryC1
{
    internal class Tiger : Creature
    {

        public Tiger()
        {
            Name = "Tiger";
            Type = Types.Beast;
            Size = Sizes.Large;
            Alignment = Alignments.Unaligned;
            HitPoints = 37 + RollMultiple(10, 5) + 10;
            ArmorClass = 12;
            Speed = "40ft";
            Attributes = [17, 15, 14, 3, 12, 8];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +3, Stealth +6";
            Senses = "darkvision 60ft, passive Perception 13";
            Actions = [
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft. , one target.
Hit: 8 (1d10 + 3) piercing damage.",
                @"
Claw. Melee Weapon Attack: +5 to hit, reach 5 ft ., one target.
Hit: 7 (1d8 + 3) slashing damage."
                ];
            Abilities = [
                @"
Keen Smell. The tiger has advantage on Wisdom (Perception)
checks that rely on smell.",
                @"
Pounce. If the tiger moves at least 20 feet straight toward a
creature and then hits it with a claw attack on the same turn,
that target must succeed on a DC 13 Strength saving throw or
be knocked prone. If the target is prone, the tiger can make one
bite attack against it as a bonus action ."
                ];
        }
    }
}
