namespace Creatures.BestiaryC2
{
    internal class Griffon : Creatures
    {

        public Griffon()
        {
            Name = "Griffon";
            Type = mo;
            Size = l;
            Alignment = ud;
            HitPoints = 30 + RollMultiple(10, 7) + 21;
            ArmorClass = 12;
            Speed = "30ft, fly 80ft";
            Attributes = [18, 15, 16, 2, 13, 8];
            ChallengeLevel = "2";
            Experience = 450;
            Skills = "Perception +5";
            Senses = "darkvision 60, passive Perception 15";
            Actions =
                [
                @"
Multiattack. The griffon makes two attacks: one with its beak
and one with its claws.",
                @"
Beak. Melee Weapon Attack: +6 to hit, reach 5 ft., one target.
Hit: 8 (1d8 + 4) piercing damage.",
                @"
Claws. Melee Weapon Attack: +6 to hit, reach 5 ft., one target.
Hit: 11 (2d6 + 4) slashing damage."
                ];
            Abilities = [
                @"
Keen Sight. The griffon has advantage on Wisdom (Perception)
checks that rely on sight."
                ];
        }
    }
}
