namespace Creatures.BestiaryC2
{
    internal class PolarBear : Creatures
    {
        public PolarBear()
        {
            Name = "Polar Bear";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 42 + RollMultiple(10, 5) + 15;
            ArmorClass = 12;
            Speed = "40ft, swim 30ft";
            Attributes = [20, 10, 16, 2, 13, 7];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +3";
            Senses = "passive Perception 13";
            Actions = [
                @"
Multiattack. The bear makes two attacks: one with its bite and
one with its claws.",
                @"
Bite. Melee Weapon Attack: +7 to hit, reach 5 ft., one target.
Hit: 9 (ld8 + 5) piercing damage.",
                @"
Claws. Melee Weapon Attack: +7 to hit, reach 5 ft ., one target.
Hit: 12 (2d6 + 5) slashing damage."
                ];
            Abilities = [
                @"
Keen Smell. The bear has advantage on Wisdom (Perception)
checks that rely on smell."
                ];
        }
    }
}
