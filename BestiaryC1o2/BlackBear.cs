namespace Creatures.BestiaryC1o2
{
    internal class BlackBear : CreatureAttributes
    {

        public BlackBear()
        {
            Name = "Black Bear";
            Type = ba;
            Size = m;
            Alignment = ud;
            HitPoints = 19 + RollMultiple(8, 3) + 6;
            ArmorClass = 11;
            Speed = "40ft, climb 30ft";
            Attributes = [15, 10, 14, 2, 12, 7];
            ChallengeLevel = "1/2";
            Experience = 100;
            Skills = "Perception +3";
            Senses = "passive Perception 13";
            Actions = [
                @"
Multiattack. The bear makes two attacks: one with its bite and
one with its claws.",
                @"
Bite. Melee Weapon Attack: +3 to hit, reach 5 ft., one target.
Hit: 5 (1 6 + 2) piercing damage.",
                @"
Claws. Melee Weapon Attack: +3 to hit, reach 5 ft ., one target.
Hit: 7 (2d4 + 2) slashing damage."
                ];
            Abilities = [
                @"
Keen Smell. The bear has advantage on Wisdom (Perception)
checks that rely on smell."
                ];
        }
    }
}
