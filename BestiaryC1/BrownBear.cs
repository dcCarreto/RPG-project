namespace Creatures.BestiaryC1
{
    internal class BrownBear : Creatures
    {

        public BrownBear()
        {
            Name = "Brown Bear";
            Type = ba;
            Size = l;
            Alignment = ud;
            HitPoints = 34 + RollMultiple(10, 4) + 2;
            ArmorClass = 11;
            Speed = "40ft, climb 30ft";
            Attributes = [19, 10, 16, 2, 13, 7];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +3";
            Senses = "passive Perception 13";
            Actions = [
                @"
Multiattack. The bear makes two attacks: one with its bite and
one with its claws.",
                @"
Bite. Melee Weapon Attack: +5 to hit, reach 5 ft. , one target.
Hit: 8 (1d8 + 4) piercing damage.",
                @"
Claws. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 11 (2d6 + 4) s lashing damage."
                ];
            Abilities = [
                @"
Keen Smell. The bear has advantage on Wisdom (Perception)
checks that rely on smell."
                ];
        }
    }
}
