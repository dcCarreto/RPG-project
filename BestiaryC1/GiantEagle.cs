using Creatures.Main;

namespace Creatures.BestiaryC1
{
    internal class GiantEagle : Creatures
    {
        readonly Dices dice = new();
        public GiantEagle()
        {
            Name = "Giant Eagle";
            Type = ba;
            Size = l;
            Alignment = ng;
            HitPoints = 26 + dice.RollMultiple(10, 4) + 4;
            ArmorClass = 13;
            Speed = "10ft, fly 80ft";
            Attributes = [16, 17, 13, 8, 14, 10];
            ChallengeLevel = "1";
            Experience = 200;
            Skills = "Perception +4";
            Senses = "passive Perception 14";
            Languages = "understands Common and Auran but can`t speak";
            Actions = [
                @"
Multiattack. The eagle makes two attacks: one with its beak
and one with its talons.",
                @"
Beak. Melee Weapon Attack: +5 to hit, reach 5 ft., one target.
Hit: 6 (1d6 + 3) piercing damage.",
                @"
Talons. Melee Weapon Attack: +5 to hit, reach 5 ft. , one target.
Hit: 10 (2d6 + 3) slashing damage."
                ];
            Abilities = [
                @"
Keen Sight. The eagle has advantage on Wisdom (Perception)
checks that rely on sight."
                ];
        }
    }
}
